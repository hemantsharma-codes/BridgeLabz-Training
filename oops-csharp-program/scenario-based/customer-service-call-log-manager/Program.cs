using CustomerServiceCallLogSystem;
using System;
public class Program
{
    private List<CallLog> callLogs = new List<CallLog>();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.StartApplication();
    }
    private void StartApplication()
    {
        ICallLogImpl iCallLogImpl = new ICallLogImpl();
        // menu
        Console.WriteLine("1.Add call log");
        Console.WriteLine("2.Search by keyword");
        Console.WriteLine("3.Filter By Time.");
        Console.WriteLine("4.Exit");

        while (true)
        {
            Console.WriteLine("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 4)
            {
                break;
            }
            switch (choice)
            {
                case 1:
                    iCallLogImpl.AddCallLog(callLogs);
                    break;
                case 2:
                    iCallLogImpl.SearchByKeyword(callLogs);
                    break;
                case 3:
                    iCallLogImpl.FilterByTime(callLogs);
                    break;
            }
        }
    }
}