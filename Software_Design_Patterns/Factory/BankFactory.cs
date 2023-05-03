using Software_Design_Patterns.Factory.Abstract_Factory;
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
                case "222222":
                    return new BankA();
                case "111111":
                    return new BankB();
            }

            return null;
        }

        public IPaymentCard GetPaymentCard(string cardNumber)
        {
            switch (cardNumber)
            {
                case "11":
                    return new VisaCardPayment();
                case "22":
                    return new MasterCardPayment();
            }

            return null;
        }
    }
}
