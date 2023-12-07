namespace SzttCegreszlegekHf
{
    // Egy observer osztály, ami kiírja, hogy mennyivel van túl lépve a maximális dolgozók száma
    class ErrorOverByObserver : IDepartmentError
    {
        public void writeError(Department sender, List<ICompanyObject> companyObject)
        {
            int childSum = companyObject.Sum(item => item.EmployeeCount);
            int newSum = sender.EmployeeCount + childSum;
            int overBy = newSum - sender.maxEmployeeCount;
            Console.WriteLine($"[Hiba] A maximális dolgozók száma túl lépve ennyivel: {overBy}");
        }
    }
}
