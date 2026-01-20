using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.SortAdhar
{
    internal class AdharManagerMenu
    {
        private IAadharManager _adharManager;
        public AdharManagerMenu()
        {
            _adharManager = new AadharManagerUtitlity(10);
        }
        public void Run()
        {
            Console.WriteLine("=========Adhar Number System=============\n");

            while (true)
            {
                Console.WriteLine("\n1. Add Aadhar");
                Console.WriteLine("2. Display All Aadhar");
                Console.WriteLine("3. Search Aadhar");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _adharManager.AddAadhar();
                        break;
                    case 2:
                        _adharManager.DisplayAadhar();
                        break;
                    case 3:
                        _adharManager.SearchAadhar();
                        break;
                    case 0:
                        Console.WriteLine("Exiting.....");
                        return;
                    default:
                        Console.WriteLine("Please enter valid chioce");
                        break;
                }
            }
        }
    }
}
