namespace SzttCegreszlegekHf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A főrészleg létrehozása
            Department mainDp = new Department("Main", 5);
            //A főrészleg felsoroló hibakezelőjének létrehozása és csatolása
            ErrorListObserver errorObserver = new();
            ErrorOverByObserver overByObserver = new();
            mainDp.Attach(errorObserver);
            mainDp.Attach(overByObserver);

            //A főrészleghez hozzáadunk két alkalmazottat
            mainDp.Add(new List<ICompanyObject> {
                new Employee("Kiss Pista", new DateTime(2010, 10, 10)), 
                new Employee("Nagy Béla", new DateTime(2011, 11, 11)) 
            });

            //Az alrészleg létrehozása
            var subDP = new Department("Sub", 4);
            //Az alrészleghez hozzáadunk négy alkalmazottat
            subDP.Add(new List<ICompanyObject>() { 
                new Employee("Sub Pista", new DateTime(2012, 2, 5)),
                new Employee("Sub Béla", new DateTime(2020, 1, 1)),
                new Employee("Sub Józsi", new DateTime(2009, 5, 6)),
                new Employee("Sub Béla", new DateTime(2004, 9, 12))
            });

            mainDp.Add(new List<ICompanyObject> {
                subDP, 
                new Employee("Közepes Béla", new DateTime(2020, 4, 4))
            });

            //Az alrészleghez hozzáadunk egy alkalmazottat, ami hibát fog okozni
            //de mivel nincs rá feliratkozva hibakezelő, ezért nem fog látszani
            subDP.Add(new Employee("C Pista", new DateTime(2010, 10, 10)));

            //Kitörlünk annyi alkalmazottat, hogy a főrészleg ne lépje túl a maximális létszámot
            subDP.Remove(subDP.Children[0]);
            subDP.Remove(subDP.Children[0]);
            mainDp.Add(subDP);

            //Listázzuk a főrészleget és az öszes gyerekét
            mainDp.List();

            Console.WriteLine(mainDp.EmployeeCount);
        }
    }
}