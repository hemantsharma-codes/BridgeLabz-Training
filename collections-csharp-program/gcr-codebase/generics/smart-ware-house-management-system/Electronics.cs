using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.SmartWareHouseManagementSystem
{
    class Electronics : WarehouseItem
    {
        public Electronics(string name) : base(name) { }

        public override void Display()
        {
            Console.WriteLine("Electronics Item: " + Name);
        }
    }
}
