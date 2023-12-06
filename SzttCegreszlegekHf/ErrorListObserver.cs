using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
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
