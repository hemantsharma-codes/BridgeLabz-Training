class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;

    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, int seat, DateTime time)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = time;
        Next = null;
    }
}
