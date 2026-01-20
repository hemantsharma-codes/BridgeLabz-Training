using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.SmartWareHouseManagementSystem
{
    class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public List<T> GetItems()
        {
            return items;
        }
    }
}
