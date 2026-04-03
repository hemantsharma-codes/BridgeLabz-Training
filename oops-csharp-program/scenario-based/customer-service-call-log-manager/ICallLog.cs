using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServiceCallLogSystem
{
    internal interface ICallLog
    {
        void AddCallLog(List<CallLog> callLogs);
        void SearchByKeyword(List<CallLog> callLogs);
        void FilterByTime(List<CallLog> callLogs);
    }
}
