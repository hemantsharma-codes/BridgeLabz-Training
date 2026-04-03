using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.scenario_based.SmartCheckoutSystem
{
    internal interface ISmartCheckout
    {
        void AddCustomer();

        void RemoveCustomer();

        void AddItem();
        void UpdateItemPrice();
    }
}
