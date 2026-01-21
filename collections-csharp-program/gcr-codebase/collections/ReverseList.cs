using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.collections
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    class ReverseList
    {
        // Reverse ArrayList without using built-in reverse
        static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }

        // Reverse LinkedList without using built-in reverse
        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversed = new LinkedList<int>();

            LinkedListNode<int> current = list.Last;
            while (current != null)
            {
                reversed.AddLast(current.Value);
                current = current.Previous;
            }

            return reversed;
        }

        static void Main(string[] args)
        {
            // ArrayList example
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original ArrayList: ");
            PrintArrayList(arrayList);

            ReverseArrayList(arrayList);
            Console.WriteLine("Reversed ArrayList: ");
            PrintArrayList(arrayList);

            // LinkedList example
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            Console.WriteLine("\nOriginal LinkedList:");
            PrintLinkedList(linkedList);

            LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
            Console.WriteLine("Reversed LinkedList:");
            PrintLinkedList(reversedLinkedList);
        }

        static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintLinkedList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
