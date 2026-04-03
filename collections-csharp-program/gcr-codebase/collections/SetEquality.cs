using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    using System;
    using System.Collections.Generic;

    class SetEquality
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 2, 1 };

            bool isEqual = set1.SetEquals(set2);

            Console.WriteLine(isEqual);
        }
    }

}
