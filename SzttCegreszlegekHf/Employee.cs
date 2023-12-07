namespace SzttCegreszlegekHf
{
    // Az alkalmazottakat reprezentáló osztály
    class Employee : ICompanyObject
    {
        private string name = "";
        public string Name { 
            get => name;
            set => name = value; 
        }
        public int EmployeeCount => 1;

        public DateTime StartOfEmployment { get; }

        public Employee(string name, DateTime start)
        {
            this.name = name;
            this.StartOfEmployment = start;
        }

        public void List()
        {
            Console.WriteLine($"Empl.   {Name}");
        }
    }
}
