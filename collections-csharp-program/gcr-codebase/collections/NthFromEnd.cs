using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class NthFromEnd
    {
        static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");

            int N = 2;

            LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;

            // Move first pointer N steps ahead
            for (int i = 0; i < N; i++)
            {
                if (first != null)
                {
                    first = first.Next;
                }
            }

            // Move both pointers until first reaches end
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            Console.WriteLine("Nth element from end: " + second.Value);
        }
    }

}
