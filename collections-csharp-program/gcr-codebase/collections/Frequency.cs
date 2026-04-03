using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    using System;
    using System.Collections.Generic;
    class Frequency
    {
        static void Main()
        {
            List<string> items = new List<string>(){"apple", "banana", "apple", "orange"};

            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < items.Count; i++)
            {
                if (count.ContainsKey(items[i]))
                {
                    count[items[i]]++;
                }
                else
                {
                    count.Add(items[i], 1);
                }
            }

            foreach (var pair in count)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }

}
