using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class UnionIntersection
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);

            HashSet<int> intersection = new HashSet<int>(set1);
            intersection.IntersectWith(set2);

            Console.WriteLine("Union:");
            PrintSet(union);

            Console.WriteLine("Intersection:");
            PrintSet(intersection);
        }

        static void PrintSet(HashSet<int> set)
        {
            foreach (int item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
