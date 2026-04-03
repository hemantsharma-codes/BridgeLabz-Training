using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScheduleManager
{
    internal class MovieManager : IMovieOperations
    {
        private static List<String> MovieTitles;
        private static List<String> ShowTimes;

        static MovieManager()
        {
            MovieTitles = new List<string>();
            ShowTimes = new List<string>();
        }

        // setters for movielist and showtime list

        public List<string> GetMovieTitle()
        {
            return MovieTitles;
        }
        public void SetMovieTitles(string movieTitle)
        {
            if(movieTitle != "")
            {
                MovieTitles.Add(movieTitle);
            }
        }
        public List<String> GetShowTime()
        {
            return ShowTimes;
        }
        public void SetShowTimes(string showTime)
        {
            if(showTime != "")
            {
                ShowTimes.Add(showTime);
            }
        }
        public void AddMovie(string movieTitle,string showTimes)
        {
            if(movieTitle != "" && showTimes != "")
            {
                MovieTitles.Add(movieTitle);
                ShowTimes.Add(showTimes);

            }
            Console.WriteLine("Movie and show time has been add succesfully...");
        }
        public void ViewMovies()
        {
            if(MovieTitles.Count == 0)
            {
                Console.WriteLine("Movie manager is empty..");
                return;
            }
            for(int i = 0; i < MovieTitles.Count; i++)
            {
                Console.WriteLine("\nMovie name is " + MovieTitles[i] + ", And the show time is " + ShowTimes[i]);
            }
        }
        public void SearchMovie(string movieTitle)
        {
            if (MovieTitles.Contains(movieTitle))
            {
                int idx = MovieTitles.IndexOf(movieTitle);
                Console.WriteLine(movieTitle + " plays at " + ShowTimes[idx]);
            }
            else
            {
                Console.WriteLine("This movie is not present in the movie manager.");
            }
        }
        public void UpdateMovie(string movieTitle)
        {
            if (MovieTitles.Contains(movieTitle))
            {
                int idx = MovieTitles.IndexOf(movieTitle);
                MovieTitles.RemoveAt(idx);
                ShowTimes.RemoveAt(idx);
                Console.WriteLine("The movie has been removed succesfuly from the movie manager..");
            }
            else
            {
                Console.WriteLine("Please enter valid information.....");
            }
        }
    }
}
