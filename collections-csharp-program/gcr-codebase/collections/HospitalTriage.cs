using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class HospitalTriage
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            // higher severity - higher priority (use negative)
            pq.Enqueue("John", -3);
            pq.Enqueue("Alice", -5);
            pq.Enqueue("Bob", -2);

            while (pq.Count > 0)
            {
                Console.Write(pq.Dequeue() + " ");
            }
        }
    }

}
