using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.SmartWareHouseManagementSystem
{
    abstract class WarehouseItem
    {
        public string Name { get; set; }
        public WarehouseItem(string name)
        {
            Name = name;
        }
        public abstract void Display();
    }

}
