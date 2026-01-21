using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.scenario_based.SmartCheckoutSystem
{
    internal class SmartCheckoutMenu
    {
        private ISmartCheckout _smartCheckout;

        public SmartCheckoutMenu()
        {
            _smartCheckout = new SmartCheckoutUtility();
        }

        public void Run()
        {
            Console.WriteLine("=====Smart Checkout System=====\n");
            while (true)
            {
                Console.WriteLine("\n1. Add Stock");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Remove Customer");
                Console.WriteLine("4. Update Stock");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _smartCheckout.AddItem();
                        break;
                    case 2:
                        _smartCheckout.AddCustomer();
                        break;
                    case 3:
                        _smartCheckout.RemoveCustomer();
                        break;
                    case 4:
                        _smartCheckout.UpdateItemPrice();
                        break;
                    case 0:
                        Console.WriteLine("Exiting.....");
                        return;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
