using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    internal class PasswordCrackerMenu
    {
        private IPasswordManager _passwordManager;
        public PasswordCrackerMenu()
        {
            _passwordManager = new PasswordManagerUtility();
        }
        public void Run()
        {
            Console.WriteLine("=========Password Cracker Simulator============");

            while (true)
            {
                Console.WriteLine("\n1. Add Password");
                Console.WriteLine("2. Crack Password");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _passwordManager.AddPassword();
                        break;
                    case 2:
                        _passwordManager.CrackPassword();
                        break;
                    case 3:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }
        }
    }
}
