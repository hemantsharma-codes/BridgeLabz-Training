using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    internal class LibraryUtilityImpl : ILibraryOperation
    {
        private static int BooksCapacity;
        private static int BookIdx;

        static LibraryUtilityImpl()
        {
            BooksCapacity = 10;
            BookIdx = 0;
        }
        private Book[] Books = new Book[BooksCapacity];

        // Add book method
        public void AddBook(Book book)
        {
            if(BookIdx == BooksCapacity)
            {
                BooksCapacity *= 2;
                Array.Resize(ref Books, BooksCapacity);
            }
            Books[BookIdx] = book;
            BookIdx++;
            Console.WriteLine("Book has been added succesfully....");
        }


        // Partial Search method
        public void PartialSearchBook(string title)
        {
            for(int i = 0; i < BookIdx; i++)
            {
                Book book = Books[i];
                if (book.GetBookTitle().Contains(title))
                {
                    Console.WriteLine("Book has been found....\nBookDetails : \n");
                    Console.WriteLine($"Book title : {book.GetBookTitle()}\nBook author : {book.GetBookAuthor()}\nBook status : {book.GetBookStatus()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Book is not present....");
                }
            }
        }


        // updating book status
        public void UpdateBookStatus(string title,string author)
        {
            for(int i = 0; i < BookIdx; i++)
            {
                Book currBook = Books[i];
                if(currBook.GetBookTitle().Equals(title) && currBook.GetBookAuthor().Equals(author))
                {
                    if(currBook.GetBookStatus().Equals("Check-in"))
                    {
                        currBook.SetBookStatus("Check-out");
                    }
                    else
                    {
                        currBook.SetBookStatus("Check-in"); 
                    }
                    Console.WriteLine("The book status has been updated succesfully....");
                    break;
                }
            }
        }

        public void DisplayAllBookDetails()
        {
            Console.WriteLine("\n=====All books Details======");

            for(int i = 0; i < BookIdx; i++)
            {
                Book book = Books[i];
                Console.WriteLine($"Book title : {book.GetBookTitle}, Book author : {book.GetBookAuthor()}, Book status : {book.GetBookStatus()}");
            }
        }
    }
}
