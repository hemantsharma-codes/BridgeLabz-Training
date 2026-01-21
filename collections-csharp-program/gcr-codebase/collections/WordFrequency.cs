using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class WordFrequency
    {
        static void Main(string[] args)
        {
            string text = "Hello world hello Java";
            text = text.ToLower();

            string[] words = text.Split(' ');
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (map.ContainsKey(words[i]))
                {
                    map[words[i]]++;
                }
                else
                {
                    map.Add(words[i], 1);
                }
            }

            foreach (var pair in map)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }

}
