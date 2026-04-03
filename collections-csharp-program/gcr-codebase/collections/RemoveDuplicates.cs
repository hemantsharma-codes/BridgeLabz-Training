using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class RemoveDuplicates
    {
        static void Main()
        {
            List<int> list = new List<int>() { 3, 1, 2, 2, 3, 4 };
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                bool exists = false;

                for (int j = 0; j < result.Count; j++)
                {
                    if (list[i] == result[j])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    result.Add(list[i]);
                }
            }

            // Print output
            foreach (int item in result)
            {
                Console.Write(item + " ");
            }
        }
    }

}
