using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
    class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public int MaxEmployeeCount { get; set; }
        public List<Department> SubDepartment { get; set; }
    }
}
