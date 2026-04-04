using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.RailwayReservationSystem
{
    /*
      Problem Statement

Design a menu-driven railway reservation system with a fixed number of confirmed seats and a priority-based waiting list.

Key Requirements

Support a fixed number of confirmed seats.

If seats are available, confirm the ticket immediately.

If seats are full, add passengers to a fixed-capacity waiting list.

Senior citizens have higher priority than general passengers.

Maintain FIFO order within the same passenger category.

On ticket cancellation, promote the highest-priority passenger from the waiting list.

Do not use collection framework classes.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Run();
        }
    }
}
