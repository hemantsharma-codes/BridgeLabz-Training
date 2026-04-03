using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.scenario_based.SmartCheckoutSystem
{
    internal class SmartCheckoutUtility : ISmartCheckout
    {
        private Queue<Customer> _cutomers;
        Dictionary<string, int> _items = new Dictionary<string, int>();
        public SmartCheckoutUtility()
        {
            _cutomers = new Queue<Customer>();
        }

        public void AddCustomer()
        {
            if(_items.Count == 0)
            {
                Console.WriteLine("Please first Add Stock....");
                return;
            }
            Console.WriteLine("Enter the name of the customer");
            string customerName = Console.ReadLine();

            Console.WriteLine("\nThe List of items with price : \n");
            foreach(var item in _items)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the number of items that you want to purchase");
            Console.WriteLine("Items count must be less than or equal to "+_items.Count);
            int itemsCount = Convert.ToInt32(Console.ReadLine());

            List<string> purchasedItems = new List<string>();
            int totalAmount = 0;
            for(int i = 0; i < itemsCount; i++)
            {
                Console.WriteLine("Enter the item name : ");
                string name = Console.ReadLine();

                if (_items.ContainsKey(name))
                {
                    totalAmount += _items[name];
                    purchasedItems.Add(name);
                }
                else
                {
                    Console.WriteLine("Please choose items from above list");
                }
            }
            Customer newCustomer = new Customer(customerName,purchasedItems,totalAmount);

            _cutomers.Enqueue(newCustomer);
            Console.WriteLine("New customer has been added succesfully");
        }
        
        public void RemoveCustomer()
        {
            Customer customer = _cutomers.Dequeue();
            Console.WriteLine(customer);
        }

        public void AddItem()
        {
            Console.WriteLine("Enter the stock name : ");
            string itemName = Console.ReadLine();

            Console.WriteLine("Enter the price of stock :");
            int price = Convert.ToInt32(Console.ReadLine());

            _items.Add(itemName, price);
            Console.WriteLine("\nNew stack has been added successfully..\n");
        }

        public void UpdateItemPrice()
        {
            Console.WriteLine("Enter the stock name");
            string itemName = Console.ReadLine();

            Console.WriteLine("Enter the new price for : "+itemName);
            int newPrice = Convert.ToInt32(Console.ReadLine());

            _items[itemName] = newPrice;

            Console.WriteLine("The Stock has been updated..");
        }
    }
}
