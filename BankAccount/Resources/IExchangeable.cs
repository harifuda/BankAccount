﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Resources
{
    interface IExchangeable
    {
        double USValue(double rate);
    }
}
