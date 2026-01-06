using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServiceCallLogSystem
{
    internal class ICallLogImpl : ICallLog
    {
        public void AddCallLog(List<CallLog> callLogs)
        {
            Console.WriteLine("Enter the phone number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the message : ");
            string message = Console.ReadLine();

            DateTime newTimeStamp = DateTime.Now;

            CallLog newCallLog = new CallLog(phoneNumber, message, newTimeStamp);
            callLogs.Add(newCallLog);
        }
        public void SearchByKeyword(List<CallLog> callLogs)
        {
            Console.WriteLine("Enter the keyword : ");
            string keyword = Console.ReadLine();

            foreach(CallLog callLog in callLogs)
            {
                string message = callLog.GetMessage();
                if (message.Contains(keyword))
                {
                    Console.WriteLine(callLog+"\n");
                }
            }
        }
        public void FilterByTime(List<CallLog> callLogs)
        {
            Console.WriteLine("Enter From timeStamp :");
            Console.WriteLine("\tEnter the year : ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the month : ");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the day : ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the hour : ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the minute : ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the seconds : ");
            int seconds = int.Parse(Console.ReadLine());
            DateTime fromTimeStamp = new DateTime(years, months, days, hours, minutes, seconds);

            Console.WriteLine("Enter the To timeStamp :");
            Console.WriteLine("\tEnter the year : ");
            years = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the month : ");
            months = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the day : ");
            days = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the hour : ");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the minute : ");
            minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("\tEnter the seconds : ");
            seconds = int.Parse(Console.ReadLine());
            DateTime toTimeStamp = new DateTime(years, months, days, hours, minutes, seconds);

            foreach (CallLog callLog in callLogs)
            {
                DateTime timeStamp = callLog.GetTimeStamp();
                if(timeStamp >= fromTimeStamp && timeStamp <= toTimeStamp)
                {
                    Console.WriteLine(callLog+"\n");
                }
            }
        }
    }
}
