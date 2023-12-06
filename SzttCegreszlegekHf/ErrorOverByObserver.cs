using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
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
