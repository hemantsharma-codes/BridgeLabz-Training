using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FlashDealz
{
    internal class ProductNode
    {
        public Product ProductInformation;
        public ProductNode Next;

        public ProductNode(Product product)
        {
            this.ProductInformation = product;
            this.Next = null;
        }


    }
}
