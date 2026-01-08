class TicketReservationSystem
{
    private TicketNode tail;
    private int count;

    public TicketReservationSystem()
    {
        tail = null;
        count = 0;
    }

    public void AddTicket(int id, string customer, string movie, int seat)
    {
        TicketNode newTicket = new TicketNode(id, customer, movie, seat, DateTime.Now);

        if (tail == null)
        {
            tail = newTicket;
            tail.Next = tail;
        }
        else
        {
            newTicket.Next = tail.Next;
            tail.Next = newTicket;
            tail = newTicket;
        }

        count++;
    }

    public void RemoveTicket(int ticketId)
    {
        if (tail == null)
            return;

        TicketNode curr = tail.Next;
        TicketNode prev = tail;

        do
        {
            if (curr.TicketId == ticketId)
            {
                if (curr == tail && curr.Next == tail)
                {
                    tail = null;
                }
                else
                {
                    prev.Next = curr.Next;
                    if (curr == tail)
                        tail = prev;
                }
                count--;
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != tail.Next);
    }

    public void DisplayTickets()
    {
        if (tail == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode temp = tail.Next;

        do
        {
            Console.WriteLine("Ticket ID: " + temp.TicketId);
            Console.WriteLine("Customer: " + temp.CustomerName);
            Console.WriteLine("Movie: " + temp.MovieName);
            Console.WriteLine("Seat: " + temp.SeatNumber);
            Console.WriteLine("Time: " + temp.BookingTime);
            Console.WriteLine("---------------------------");

            temp = temp.Next;

        } while (temp != tail.Next);
    }

    public void SearchTicket(string keyword)
    {
        if (tail == null)
            return;

        TicketNode temp = tail.Next;
        bool found = false;

        do
        {
            if (temp.CustomerName.Equals(keyword, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ticket ID: " + temp.TicketId);
                Console.WriteLine("Customer: " + temp.CustomerName);
                Console.WriteLine("Movie: " + temp.MovieName);
                Console.WriteLine("Seat: " + temp.SeatNumber);
                Console.WriteLine("Time: " + temp.BookingTime);
                Console.WriteLine("---------------------------");
                found = true;
            }

            temp = temp.Next;

        } while (temp != tail.Next);

        if (!found)
            Console.WriteLine("No matching ticket found");
    }

    public int TotalTickets()
    {
        return count;
    }
}
