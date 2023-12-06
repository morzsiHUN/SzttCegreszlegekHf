using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel;

namespace SzttCegreszlegekHf
{
    class Department : ICompanyObject
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
                Console.WriteLine($"[Hiba] Sikertelen hozzáadás a {name} részleghez, mert a megadott maximális létszám {maxEmployeeCount}, míg az új létszám {newSum} lenne.");
                return false;
            }
            children.AddRange(child);
            return true;
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

    }
}
