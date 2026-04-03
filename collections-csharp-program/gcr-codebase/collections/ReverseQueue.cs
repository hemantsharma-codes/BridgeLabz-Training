using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    class ReverseQueue
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Stack<int> stack = new Stack<int>();

            // Move queue elements to stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            // Move back to queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
        }
    }

}
