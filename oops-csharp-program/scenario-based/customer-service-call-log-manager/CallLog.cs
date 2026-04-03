using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServiceCallLogSystem
{
    internal class CallLog
    {
        private long phoneNumber;
        private string message;
        private DateTime timeStamp;

        internal CallLog(long phoneNumber, string message, DateTime timeStamp)
        {
            this.phoneNumber = phoneNumber;
            this.message = message;
            this.timeStamp = timeStamp;
        }

        public long GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string GetMessage()
        {
            return this.message;
        }
        public DateTime GetTimeStamp()
        {
            return this.timeStamp;
        }

        public override string ToString()
        {
            return $"\nPhone Number : {phoneNumber}\nMessage : {message}\nTime Stamp : {timeStamp}";
        }
    }
}
