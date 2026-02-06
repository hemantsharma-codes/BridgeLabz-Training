using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.RailwayReservationSystem
{
    sealed class Menu
    {
        IRailwayManager _railwayManager;

        public Menu()
        {
            _railwayManager = new RailwayManagerUtility();
        }

        public void Run()
        {
            Console.WriteLine("=======Railway Reservation System======");
            while (true)
            {
                Console.WriteLine("\n1. Book Ticket");
                Console.WriteLine("2. Check Status");
                Console.WriteLine("0. Exit");


                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _railwayManager.BookTicket();
                        break;
                    case 2:
                        _railwayManager.CheckStatus();
                        break;
                    case 0:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
