using MovieScheduleManager;
using System;
class MovieScheduleManagerMain
{
    private static MovieScheduleManagerMenu MovieMenu;
    static void Main(string[] args)
    {
        MovieMenu = new MovieScheduleManagerMenu();
        MovieMenu.Choice();
    }
}