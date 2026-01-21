using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class SymmetricDifference
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            HashSet<int> result = new HashSet<int>(set1);
            result.SymmetricExceptWith(set2);

            foreach (int item in result)
            {
                Console.Write(item + " ");
            }
        }
    }

}
