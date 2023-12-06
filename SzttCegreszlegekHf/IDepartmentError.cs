using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
    interface IDepartmentError
    {
        void writeError( Department sender, List<ICompanyObject> companyObject);
    }
}
