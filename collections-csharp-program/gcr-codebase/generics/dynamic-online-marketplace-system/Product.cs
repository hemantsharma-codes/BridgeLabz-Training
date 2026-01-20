using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.DynamicOnlineMarketPlaceSystem
{
    class Product<T> where T : class
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }

}
