﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Factory
{
    public interface IBankFactory
    {
        IBank GetBank(String bankCode);
    }
}
