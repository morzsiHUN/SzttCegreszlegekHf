namespace SzttCegreszlegekHf
{
    // A cég részlegeit reprezentáló osztály
    // Itt történnek a rekurzív hívások
    // Ez egy összetett elem
    class Department : ObservableSubject<IDepartmentError, List<ICompanyObject>>, ICompanyObject
    {
        private string name = "";
        public string Name { 
            get => name; 
            set => name = value; 
        }

        public int EmployeeCount
        {
            get
            {
                int sum = 0;
                foreach (ICompanyObject item in children)
                {
                    sum += item.EmployeeCount;
                }
                return sum;
            }
        }
        public int maxEmployeeCount { get; }

        private List<ICompanyObject> children = new List<ICompanyObject>();
        public List<ICompanyObject> Children { get => children; }

        public Department(string name, int maxEmployeeCount)
        {
            Name = name;
            this.maxEmployeeCount = maxEmployeeCount;
        }

        public bool Add(List<ICompanyObject> child)
        {
            int childSum = child.Sum(item => item.EmployeeCount);
            int newSum = EmployeeCount + childSum;
            if (newSum > maxEmployeeCount)
            {
                Notify(child);
                return false;
            }
            children.AddRange(child);
            return true;
        }
        public bool Add(ICompanyObject child)
        {
            return this.Add(new List<ICompanyObject> { child });
        }

        public bool Remove(ICompanyObject child)
        {
            return children.Remove(child);
        }

        public void List()
        {
            Console.WriteLine($"Dept.   {Name}");
            children.ForEach(item => item.List());
        }

        protected override void Notify(List<ICompanyObject> msg)
        {
            observers.ForEach(item => item.writeError(this, msg));
        }
    }
}
