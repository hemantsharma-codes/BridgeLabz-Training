using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class RotateList
    {
        static void Main()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            int k = 2;   // number of rotations

            int n = list.Count;
            k = k % n;   // handle large rotations

            // store first k elements
            int[] temp = new int[k];
            for (int i = 0; i < k; i++)
            {
                temp[i] = list[i];
            }

            // shift elements to the left
            for (int i = k; i < n; i++)
            {
                list[i - k] = list[i];
            }

            // put stored elements at the end
            for (int i = 0; i < k; i++)
            {
                list[n - k + i] = temp[i];
            }

            // print result
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }
    }

}
