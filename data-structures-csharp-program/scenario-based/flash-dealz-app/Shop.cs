using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FlashDealz
{
    internal class Shop : IShop
    {
        private LinkedList ProductsList;

        public Shop()
        {
            ProductsList = new LinkedList();
        }

        public void AddProduct()
        {
            Console.WriteLine("Enter the product name :");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the product rate :");
            double productRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Product Discount (in percent):");
            double productDiscount = Convert.ToDouble(Console.ReadLine());

            // calculating final rate
            double discountAmount = (productRate * productDiscount) / 100;
            double finalRate = productRate - discountAmount;


            Product product = new Product(productName, productRate, productDiscount, finalRate);

            ProductsList.Add(product);
            ProductsList.SortByDiscountDescending();
            Console.WriteLine("The product has been added succesfully.....");

        }

        public void UpdateProductDiscount()
        {
            Console.WriteLine("Enter the name of the product whose discount you want to update:");
            string productName = Console.ReadLine().Trim().ToLower();

            Product product = ProductsList.SearchProduct(productName);

            if (product != null)
            {
                Console.WriteLine("Enter the new discount percentage:");
                double newDiscount = Convert.ToDouble(Console.ReadLine());

                product.SetProductDiscount(newDiscount);

                // calculating final amount
                double productRate = product.GetProductRate();
                double discountAmount = (productRate * newDiscount) / 100;
                double newFinalRate = productRate - discountAmount;

                product.SetProductFinalRate(newFinalRate);
                ProductsList.SortByDiscountDescending();

                Console.WriteLine("The discount has been updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found. Please enter valid information.");
            }
        }


        public void DisplayAllProduct()
        {
            ProductsList.DisplayList();
        }
    }
}
