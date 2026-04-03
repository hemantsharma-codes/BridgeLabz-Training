using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.DynamicOnlineMarketPlaceSystem
{
    class DiscountUtility
    {
        public static void ApplyDiscount<T>(Product<T> product, double percentage)
            where T : class
        {
            product.Price -= product.Price * (percentage / 100);
        }
    }
}
