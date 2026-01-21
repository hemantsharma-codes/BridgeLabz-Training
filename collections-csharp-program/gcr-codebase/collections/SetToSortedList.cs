using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class SetToSortedList
    {
        static void Main()
        {
            HashSet<int> set = new HashSet<int>() { 5, 3, 9, 1 };
            List<int> list = new List<int>(set);

            // Bubble sort
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }
    }

}
