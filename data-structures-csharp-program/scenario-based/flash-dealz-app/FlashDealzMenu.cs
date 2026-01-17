using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FlashDealz
{
    sealed class FlashDealzMenu
    {
        private IShop shop;

        public FlashDealzMenu()
        {
            shop = new Shop();
        }
        public void StartApp()
        {
            Console.WriteLine("=======Flash Dealz Shop System==========");

            while (true)
            {
                Console.WriteLine("\n1. Add Product");
                Console.WriteLine("2. Update discount percentage");
                Console.WriteLine("3. Display all product");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        shop.AddProduct();
                        break;
                    case 2:
                        shop.UpdateProductDiscount();
                        break;
                    case 3:
                        shop.DisplayAllProduct();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Please enter the vaild choice");
                        break;
                }
            }
        }
    }
}
