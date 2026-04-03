using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.DynamicOnlineMarketPlaceSystem
{
    class Menu
    {
        private List<object> catalog = new List<object>();

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Online Marketplace Menu ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Clothing");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Apply Discount");
                Console.WriteLine("0. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        AddClothing();
                        break;
                    case 3:
                        DisplayProducts();
                        break;
                    case 4:
                        ApplyDiscount();
                        break;
                }

            } while (choice != 0);
        }

        private void AddBook()
        {
            Console.Write("Enter book name: ");
            string name = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Product<BookCategory> book = new Product<BookCategory>(name, price);
            catalog.Add(book);
        }

        private void AddClothing()
        {
            Console.Write("Enter clothing name: ");
            string name = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Product<ClothingCategory> cloth = new Product<ClothingCategory>(name, price);
            catalog.Add(cloth);
        }

        private void DisplayProducts()
        {
            foreach (var item in catalog)
            {
                if (item is Product<BookCategory> book)
                    book.Display();
                else if (item is Product<ClothingCategory> cloth)
                    cloth.Display();
            }
        }

        private void ApplyDiscount()
        {
            Console.Write("Enter discount percentage: ");
            double discount = double.Parse(Console.ReadLine());

            foreach (var item in catalog)
            {
                if (item is Product<BookCategory> book)
                    DiscountUtility.ApplyDiscount(book, discount);
                else if (item is Product<ClothingCategory> cloth)
                    DiscountUtility.ApplyDiscount(cloth, discount);
            }

            Console.WriteLine("Discount applied successfully!");
        }
    }

}
