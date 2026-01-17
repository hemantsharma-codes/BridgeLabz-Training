using System;
namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BookShelfSystem
{
    internal class Library
    {
        private CustomHashMap catalog;

        public Library()
        {
            catalog = new CustomHashMap();
        }

        public void AddBook(string genre, string title, string author)
        {
            catalog.AddBook(genre, new Book(title, author));
        }

        public void BorrowBook(string genre, string title)
        {
            catalog.RemoveBook(genre, title);
        }

        public void ShowGenre(string genre)
        {
            catalog.DisplayGenre(genre);
        }
    }
}
