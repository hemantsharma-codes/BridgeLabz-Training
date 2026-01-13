using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieScheduleManager
{
    internal interface IMovieOperations
    {
        void AddMovie(string movieTitle,string showTimes);
        void ViewMovies();
        void SearchMovie(string movieTitle);
        void UpdateMovie(string movieTitle);
    }
}
