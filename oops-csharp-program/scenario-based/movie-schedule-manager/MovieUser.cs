using System;
namespace MovieScheduleManager
{
    internal class MovieUser
    {
        private MovieManager movieManager;

        public MovieUser()
        {
            movieManager = new MovieManager();
        }

        public void ViewMovies()
        {
            movieManager.ViewMovies();
        }

        public void SearchMovie(string movieTitle)
        {
            movieManager.SearchMovie(movieTitle);
        }
    }
}
