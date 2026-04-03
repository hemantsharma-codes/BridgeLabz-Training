using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    internal class PageDoublyLinkedList
    {
        // Private inner class for the DLL node
        private class PageNode
        {
            public Page Data { get; set; }
            public PageNode Prev { get; set; }
            public PageNode Next { get; set; }

            public PageNode(Page data)
            {
                Data = data;
                Prev = null;
                Next = null;
            }
        }

        private PageNode head;
        private PageNode tail;
        private PageNode current;  // current page pointer

        public PageDoublyLinkedList()
        {
            head = null;
            tail = null;
            current = null;
        }

        // Visit a new page
        public void AddPage(Page page)
        {
            PageNode newNode = new PageNode(page);

            if (head == null)
            {
                head = tail = current = newNode;
                return;
            }

            if (current == tail)
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
                current = newNode;
            }
            else
            {
                // Remove forward history
                PageNode temp = current.Next;
                while (temp != null)
                {
                    PageNode next = temp.Next;
                    temp.Prev = null;
                    temp.Next = null;
                    temp = next;
                }

                current.Next = newNode;
                newNode.Prev = current;
                tail = newNode;
                current = newNode;
            }
        }

        public void GoBack()
        {
            if (current?.Prev != null)
                current = current.Prev;
            else
                Console.WriteLine("No previous page.");
        }

        public void GoForward()
        {
            if (current?.Next != null)
                current = current.Next;
            else
                Console.WriteLine("No next page.");
        }

        public void DisplayCurrentPage()
        {
            if (current != null)
                current.Data.Display();
            else
                Console.WriteLine("No pages.");
        }

        public void PrintAllPages()
        {
            PageNode temp = head;
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Next;
            }
        }
    }

}
