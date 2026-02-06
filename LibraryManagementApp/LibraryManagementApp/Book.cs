using System;

namespace LibraryManagementApp
{
    internal class Book
    {
        private string BookTitle;
        private string BookAuthor;
        private string BookStatus;

        public Book(string title, string author, string status)
        {
            this.BookTitle = title;
            this.BookAuthor = author;
            this.BookStatus = status;
        }

        // getter setter
        public string GetBookTitle()
        {
            return this.BookTitle;
        }

        public string GetBookAuthor()
        {
            return this.BookAuthor;
        }

        public string GetBookStatus()
        {
            return BookStatus;
        }

        public void SetBookStatus(string status)
        {
            this.BookStatus = status;
        }
    }
}
