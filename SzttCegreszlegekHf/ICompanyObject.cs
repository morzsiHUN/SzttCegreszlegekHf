﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
    interface ICompanyObject
    {
        string Name { get; set; }
        int EmployeeCount { get; }

        void List();
    }
}
