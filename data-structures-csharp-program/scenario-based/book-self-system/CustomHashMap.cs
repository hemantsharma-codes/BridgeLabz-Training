using System;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BookShelfSystem
{
    internal class CustomHashMap
    {
        private HashNode[] table;
        private int size = 10;

        public CustomHashMap()
        {
            table = new HashNode[size];
        }

        private int GetHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
                hash += c;

            return hash % size;
        }

        public void AddBook(string genre, Book book)
        {
            int index = GetHash(genre);

            if (table[index] == null)
            {
                table[index] = new HashNode(genre);
            }

            HashNode current = table[index];

            while (true)
            {
                if (current.genre == genre)
                {
                    current.books.AddBook(book);
                    return;
                }

                if (current.next == null)
                    break;

                current = current.next;
            }

            current.next = new HashNode(genre);
            current.next.books.AddBook(book);
        }

        public void RemoveBook(string genre, string title)
        {
            int index = GetHash(genre);
            HashNode current = table[index];

            while (current != null)
            {
                if (current.genre == genre)
                {
                    current.books.RemoveBook(title);
                    return;
                }
                current = current.next;
            }
        }

        public void DisplayGenre(string genre)
        {
            int index = GetHash(genre);
            HashNode current = table[index];

            while (current != null)
            {
                if (current.genre == genre)
                {
                    current.books.DisplayBooks();
                    return;
                }
                current = current.next;
            }

            Console.WriteLine("Genre not found");
        }
    }
}
