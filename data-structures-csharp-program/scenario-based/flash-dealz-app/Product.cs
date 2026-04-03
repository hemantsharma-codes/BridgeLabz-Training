using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FlashDealz
{
    internal class Product
    {
        private string ProductName;
        private double ProductRate;
        private double ProductDiscount;
        private double ProuductFinalRate;

        // constructor
        public Product(string productName,double productRate,double productDiscount,double productFinalRate)
        {
            this.ProductName = productName;
            this.ProductRate = productRate;
            this.ProductDiscount = productDiscount;
            this.ProuductFinalRate = productFinalRate;
        }
        //getter for every field
        public string GetProductName()
        {
            return this.ProductName;
        }
        public double GetProductRate()
        {
            return this.ProductRate;
        }
        public double GetProductDiscount()
        {
            return this.ProductDiscount;
        }

        public double GetProductFinalRate()
        {
            return this.ProuductFinalRate;
        }

        // setter for updating the value of product discount and product final rate
        public void SetProductDiscount(double discount)
        {
            this.ProductDiscount = discount;
        }
        public void SetProductFinalRate(double finalRate)
        {
            this.ProuductFinalRate = finalRate;
        }

        // overridng ToString() method

        public override string ToString()
        {
            return $"\nProduct Name : {ProductName}\t Product Rate : {ProductRate}\t Product Discount : {ProductDiscount}\t Product Final Rae : {ProuductFinalRate}";
        }
    }
}
