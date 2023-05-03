using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Proxy
{
    public class SMSServiceImpl : SMSService
    {
        public override string SendSMS(string custId, string mobile, string sms)
        {
            return $"for customerId {custId} ,sms send to {mobile}";
        }
    }
}
