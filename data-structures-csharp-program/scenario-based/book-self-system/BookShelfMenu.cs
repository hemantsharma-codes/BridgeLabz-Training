//using System;

//namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BookShelfSystem
//{
//    internal class BookShelfMenu
//    {
//        private Library library;

//        public BookShelfMenu()
//        {
//            library = new Library();
//        }

//        public void ShowMenu()
//        {
//            while (true)
//            {
//                Console.WriteLine("\n=== BookShelf Library Menu ===");
//                Console.WriteLine("1. Add Book");
//                Console.WriteLine("2. Borrow Book");
//                Console.WriteLine("3. View Books by Genre");
//                Console.WriteLine("0. Exit");
//                Console.Write("Enter choice: ");

//                int choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        AddBookMenu();
//                        break;

//                    case 2:
//                        BorrowBookMenu();
//                        break;

//                    case 3:
//                        ViewGenreMenu();
//                        break;

//                    case 0:
//                        return;

//                    default:
//                        Console.WriteLine("Invalid choice");
//                        break;
//                }
//            }
//        }

//        private void AddBookMenu()
//        {
//            Console.Write("Enter Genre: ");
//            string genre = Console.ReadLine();

//            Console.Write("Enter Book Title: ");
//            string title = Console.ReadLine();

//            Console.Write("Enter Author Name: ");
//            string author = Console.ReadLine();

//            library.AddBook(genre, title, author);
//            Console.WriteLine("Book added successfully");
//        }

//        private void BorrowBookMenu()
//        {
//            Console.Write("Enter Genre: ");
//            string genre = Console.ReadLine();

//            Console.Write("Enter Book Title: ");
//            string title = Console.ReadLine();

//            library.BorrowBook(genre, title);
//            Console.WriteLine("Book borrowed (removed from shelf)");
//        }

//        private void ViewGenreMenu()
//        {
//            Console.Write("Enter Genre: ");
//            string genre = Console.ReadLine();

//            Console.WriteLine("\nBooks in " + genre + ":");
//            library.ShowGenre(genre);
//        }
//    }
//}
