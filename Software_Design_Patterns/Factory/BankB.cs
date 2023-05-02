using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Factory
{
    public class BankB : IBank
    {
        public string WithDrow()
        {
            return "Your request is handled by bankB";
        }

       
    }
}
