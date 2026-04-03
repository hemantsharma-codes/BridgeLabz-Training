using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    internal class BookBuddyUtility
    {
        private static int CapacityOfBooks;
        private static int BookIdx;
        private string[] Books = new string[CapacityOfBooks];

        static BookBuddyUtility()
        {
            CapacityOfBooks = 10;
            BookIdx = 0;
        }
        public void AddBook(string book)
        {
            if(BookIdx == CapacityOfBooks)
            {
                CapacityOfBooks *= 2;
                Array.Resize(ref Books, CapacityOfBooks);
            }
            if(book != "")
            {
                Books[BookIdx] = book;
                BookIdx++;
                Console.WriteLine("Book has been added succesfully...");
            }

        }

        public void SortBookAlphabetically()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                for (int j = i + 1; j < Books.Length; j++)
                {
                    string book1 = Books[i].Split('-')[0].Trim();
                    string book2 = Books[j].Split('-')[0].Trim();

                    if (string.Compare(book1, book2, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        string temp = Books[i];
                        Books[i] = Books[j];
                        Books[j] = temp;
                    }
                }
            }

            Console.WriteLine("The book has been sorted alphabetically...");
        }
        public void SearchByAuthor(string author)
        {
            foreach(string book in Books)
            {
                string[] bookArr = book.Split('-');
                string bookName = bookArr[0].ToLower();
                string authorName = bookArr[1].ToLower();
                if(authorName == author)
                {
                    Console.WriteLine("Book : " + bookName + ", Author : " + authorName);
                }
                else
                {
                    Console.WriteLine("The book is not present in library..");
                }
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All book Details are : \n");
            foreach(string book in Books)
            {
                string[] bookDetails = book.Split('-');
                string bookName = bookDetails[0];
                string bookAuthorName = bookDetails[1];

                Console.WriteLine(bookName+"===>"+bookAuthorName);
            }
        }
    }
}
