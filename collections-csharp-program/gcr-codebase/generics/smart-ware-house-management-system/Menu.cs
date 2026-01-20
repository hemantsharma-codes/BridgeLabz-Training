using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.SmartWareHouseManagementSystem
{
    class Menu
    {
        private Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        private Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        private Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Smart Warehouse Menu ---");
                Console.WriteLine("1. Add Electronics");
                Console.WriteLine("2. Add Groceries");
                Console.WriteLine("3. Add Furniture");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("0. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        electronicsStorage.AddItem(new Electronics("Laptop"));
                        break;

                    case 2:
                        groceriesStorage.AddItem(new Groceries("Rice"));
                        break;

                    case 3:
                        furnitureStorage.AddItem(new Furniture("Chair"));
                        break;

                    case 4:
                        DisplayAllItems();
                        break;
                }
            } while (choice != 0);
        }

        // 🔹 Variance used here (IEnumerable<WarehouseItem>)
        private void DisplayItems(IEnumerable<WarehouseItem> items)
        {
            foreach (var item in items)
            {
                item.Display();
            }
        }

        private void DisplayAllItems()
        {
            Console.WriteLine("\n--- Electronics ---");
            DisplayItems(electronicsStorage.GetItems());

            Console.WriteLine("\n--- Groceries ---");
            DisplayItems(groceriesStorage.GetItems());

            Console.WriteLine("\n--- Furniture ---");
            DisplayItems(furnitureStorage.GetItems());
        }
    }
}
