using System;
namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BookShelfSystem
{
    internal class BookLinkedList
    {
        private BookNode head;

        public void AddBook(Book book)
        {
            BookNode newNode = new BookNode(book);

            if (head == null)
            {
                head = newNode;
                return;
            }

            BookNode temp = head;
            while (temp.next != null)
                temp = temp.next;

            temp.next = newNode;
        }

        public void RemoveBook(string title)
        {
            if (head == null) return;

            if (head.data.title == title)
            {
                head = head.next;
                return;
            }

            BookNode curr = head;
            while (curr.next != null)
            {
                if (curr.next.data.title == title)
                {
                    curr.next = curr.next.next;
                    return;
                }
                curr = curr.next;
            }
        }

        public void DisplayBooks()
        {
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Book: {temp.data.title}, Author: {temp.data.author}");
                temp = temp.next;
            }
        }
    }
}
