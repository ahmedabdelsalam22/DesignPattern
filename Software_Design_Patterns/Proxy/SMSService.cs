using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Proxy
{
    public abstract class SMSService
    {
        public abstract string SendSMS(string custId , string mobile, string sms);

        
    }
}
