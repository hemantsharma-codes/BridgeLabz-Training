using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    sealed class BookBuddyMenu
    {
        private BookBuddyUtility bookBuddy;
        public void Choice()
        {
            bookBuddy = new BookBuddyUtility();
            while (true)
            {
                Console.WriteLine("\n1. Add Book (BookName-AuthorName)");
                Console.WriteLine("2. Sort Book Alphabetically");
                Console.WriteLine("3. Search By Author");
                Console.WriteLine("4. Display All Books");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter user choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the book details : ");
                        string bookDetails = Console.ReadLine();
                        bookBuddy.AddBook(bookDetails);
                        break;
                    case 2:
                        bookBuddy.SortBookAlphabetically();
                        break;
                    case 3:
                        Console.WriteLine("Enter the author name ");
                        string authorName = Console.ReadLine();
                        bookBuddy.SearchByAuthor(authorName);
                        break;
                    case 4:
                        bookBuddy.DisplayAllBooks();
                        break;
                    case 5:
                        Console.WriteLine("Exiting.....");
                        return;
                }
            }
        }
    }
}
