using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.EduResults
{

    internal class Menu
    {
        private IEducationalBoard _educationalBoard;
        
        public Menu()
        {
            _educationalBoard = new EducationBoard(10);
        }

        public void Run()
        {
            Console.WriteLine("======Edu Result System=======");

            while (true)
            {
                Console.WriteLine("\n1. Add Distric");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Display All Distric");
                Console.WriteLine("4. Display state-wise rank list");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _educationalBoard.AddDistric();
                        break;
                    case 2:
                        _educationalBoard.AddStudent();
                        break;
                    case 3:
                        _educationalBoard.DisplayAllDistric();
                        break;
                    case 4:
                        _educationalBoard.DisplayRankWise();
                        break;
                    case 0:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
