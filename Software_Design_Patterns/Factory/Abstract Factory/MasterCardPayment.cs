using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Factory.Abstract_Factory
{
    public class MasterCardPayment : IPaymentCard
    {
        public string GetName()
        {
            return "MasterCardPayment";
        }
    }
}
