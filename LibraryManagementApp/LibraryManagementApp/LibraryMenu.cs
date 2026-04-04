using System;

namespace LibraryManagementApp
{
    sealed class LibraryMenu
    {
        private ILibraryOperation libraryOperations;

        public void Choice()
        {
            libraryOperations = new LibraryUtilityImpl(); 
            Book book;

            while (true)
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Partial Search");
                Console.WriteLine("3. Update status");
                Console.WriteLine("4. Exit...");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the title of the book");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter the author of the book");
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter the status of the book(Check-in/Check-out)");
                        string status = Console.ReadLine();

                        book = new Book(title, author, status);
                        libraryOperations.AddBook(book);
                        break;

                    case 2:
                        Console.WriteLine("Enter the title of the book");
                        title = Console.ReadLine();
                        libraryOperations.PartialSearchBook(title);
                        break;

                    case 3:
                        Console.WriteLine("Enter the book title");
                        title = Console.ReadLine();

                        Console.WriteLine("Enter the book author");
                        author = Console.ReadLine();

                        libraryOperations.UpdateBookStatus(title, author);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
