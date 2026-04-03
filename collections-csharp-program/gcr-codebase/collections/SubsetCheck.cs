using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class SubsetCheck
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int>() { 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 1, 2, 3, 4 };

            bool isSubset = set1.IsSubsetOf(set2);

            Console.WriteLine(isSubset);
        }
    }

}
