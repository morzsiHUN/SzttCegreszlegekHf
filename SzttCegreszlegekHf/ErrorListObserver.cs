namespace SzttCegreszlegekHf
{
    // Egy observber osztály, ami kiírja a hibákat okozó composite elemeket nevét
    class ErrorListObserver : IDepartmentError
    {
        public void writeError(Department sender, List<ICompanyObject> companyObject)
        {
            Console.Write("[Hiba] ");
            string list = companyObject.Aggregate("", (current, child) => current + (child.Name + ";"));
            Console.Write(list.Substring(0, list.Length - 1));
            Console.WriteLine();
        }
    }
}
