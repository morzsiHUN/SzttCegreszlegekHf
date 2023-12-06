namespace SzttCegreszlegekHf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department mainDp = new Department("Main", 5);
            mainDp.Add(new List<ICompanyObject> {
                new Employee("Kiss Pista", new DateTime(2010, 10, 10)), 
                new Employee("Nagy Béla", new DateTime(2011, 11, 11)) 
            });
            var subDP = new Department("Sub", 2);
            subDP.Add(new List<ICompanyObject>() { 
                new Employee("Sub Pista", new DateTime(2010, 10, 10)),
                new Employee("Sub Béla", new DateTime(2011, 11, 11))
            });
            mainDp.Add(new List<ICompanyObject> {subDP});
            subDP.Add(new List<ICompanyObject>()
            {
                new Employee("C Pista", new DateTime(2010, 10, 10))
            });
            mainDp.List();
            Console.WriteLine(mainDp.EmployeeCount);
        }
    }
}