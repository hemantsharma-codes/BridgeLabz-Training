using System;
class TicketMain
{
    static void Main(string[] args)
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicket(101, "Alice", "Inception", 12);
        system.AddTicket(102, "Bob", "Interstellar", 15);
        system.AddTicket(103, "Charlie", "Inception", 18);

        system.DisplayTickets();

        system.SearchTicket("Inception");

        system.RemoveTicket(102);

        system.DisplayTickets();

        Console.WriteLine("Total Tickets Booked: " + system.TotalTickets());
    }
}
