using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Factory
{
    public class BankFactory : IBankFactory
    {
        public IBank GetBank(String bankCode)
        {
            switch (bankCode)
            {
                case "123456":
                    return new BankA();
                case "111111":
                    return new BankB();
            }

            return null;
        }

       
    }
}
