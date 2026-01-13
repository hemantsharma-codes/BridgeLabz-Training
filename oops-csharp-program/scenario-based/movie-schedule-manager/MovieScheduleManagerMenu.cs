using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScheduleManager
{
    sealed class MovieScheduleManagerMenu
    {
        private static IMovieOperations movieOperations;
        public void Choice()
        {
            Console.WriteLine("===================Movie Schedule Manager================");
            while (true)
            {
                Console.WriteLine("\n1.Movie Manger");
                Console.WriteLine("2. Movie User");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Please enter your choice (1/2/3)");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManagerMenu();
                        break;
                    case 2:
                        UserMenu();
                        break;
                    case 3:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Please enter the valid information");
                        break;
                }
            }
        }
        public void ManagerMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add movie");
                Console.WriteLine("2. View movies");
                Console.WriteLine("3. Search movies");
                Console.WriteLine("4. Update movies");
                Console.WriteLine("5. Exit");

                Console.WriteLine("\nPlease enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        movieOperations = new MovieManager();
                        Console.WriteLine("\nEnter the movie title");
                        string movieTitle = Console.ReadLine();
                        Console.WriteLine("Enter the Show Time");
                        string showTime = Console.ReadLine();

                        movieOperations.AddMovie(movieTitle,showTime);
                        break;
                    case 2:
                        movieOperations = new MovieManager();
                        movieOperations.ViewMovies();
                        break;
                    case 3:
                        movieOperations = new MovieManager();
                        Console.WriteLine("\nEnter the name of the movie for searching...");
                        movieTitle = Console.ReadLine();

                        movieOperations.SearchMovie(movieTitle);
                        break;
                    case 4:
                        movieOperations = new MovieManager();
                        Console.WriteLine("\n Enter the movie name for updating....");
                        movieTitle = Console.ReadLine();
                        movieOperations.UpdateMovie(movieTitle);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                }
            }
        }
        public void UserMenu()
        {
            MovieUser movieUser = new MovieUser();
            while (true)
            {
                Console.WriteLine("\n1. View Movies");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Exit");

                Console.WriteLine("\n Enter user choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        movieUser.ViewMovies();
                        break;
                    case 2:
                        Console.WriteLine("Enter the movie name that user wants to search");
                        string movieTitle = Console.ReadLine();
                        movieUser.SearchMovie(movieTitle);
                        break;
                    case 3:
                        Console.WriteLine("Exiting....");
                        return;
                }
            }
        }
    }
}
