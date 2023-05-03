using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.Proxy
{
    public class SMSServiceProxy
    {
        private SMSService _smsService;

        Dictionary<string, int> _storedSentCount = new Dictionary<string, int>();
        public string SendSMS(string custId, string mobile, string sms)
        {
            if (_smsService == null) 
            {
                _smsService = new SMSServiceImpl();
            }
            if (!_storedSentCount.ContainsKey(custId))
            {
                //sent first message from custId
                _storedSentCount.Add(custId, 1);
                return _smsService.SendSMS(custId, mobile, sms);
            }
            else 
            {
                var customer = _storedSentCount.Where(c=>c.Key == custId).FirstOrDefault();
                if (customer.Value >= 3)
                {
                    return "Not allowed because you send 3 sms";
                }
                else {
                    _storedSentCount[custId] = customer.Value + 1;
                    return _smsService.SendSMS(custId, mobile,sms);
                }
            }
            
        }
    }
}
