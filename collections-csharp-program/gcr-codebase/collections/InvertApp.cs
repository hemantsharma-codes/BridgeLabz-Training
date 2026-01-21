using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class InvertMap
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>();
            input.Add("A", 1);
            input.Add("B", 2);
            input.Add("C", 1);

            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            foreach (var pair in input)
            {
                if (!inverted.ContainsKey(pair.Value))
                {
                    inverted[pair.Value] = new List<string>();
                }
                inverted[pair.Value].Add(pair.Key);
            }

            foreach (var pair in inverted)
            {
                Console.Write(pair.Key + " = ");
                foreach (string val in pair.Value)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
