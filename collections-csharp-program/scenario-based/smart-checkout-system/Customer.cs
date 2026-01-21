using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.scenario_based.SmartCheckoutSystem
{
    internal class Customer
    {
        private string _customerName;
        private List<string> _purchasedItems = new List<string>();
        private int _totalAmount;
        public Customer(string customerName,List<string> items,int totalAmount)
        {
            this._customerName = customerName;
            this._purchasedItems = items;
            this._totalAmount = totalAmount;
        }

        public override string ToString()
        {
            return $"Customer Name : {_customerName}\nPurchased Item : {_customerName}\tTotal Bill : {_totalAmount}";
        }
    }
}
