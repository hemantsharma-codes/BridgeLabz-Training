using System;
class HotelBooking{
    private string guestName;
    private string roomType;
    private int nights;

    // Public properties
    public string GuestName{
        get { return guestName; }
    }

    public string RoomType{
        get { return roomType; }
    }

    public int Nights{
        get { return nights; }
    }

    // Default constructor
    public HotelBooking(){
        guestName = "Not Assigned";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights){
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking hb){
        guestName = hb.guestName;
        roomType = hb.roomType;
        nights = hb.nights;
    }
}
class HotelBookingDemo{
    static void Main(){
        // Default booking
        HotelBooking b1 = new HotelBooking();

        // Parameterized booking
        Console.Write("Enter Guest Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Room Type: ");
        string room = Console.ReadLine();

        Console.Write("Enter Number of Nights: ");
        int nights = int.Parse(Console.ReadLine());

        HotelBooking b2 = new HotelBooking(name, room, nights);

        // Copy booking
        HotelBooking b3 = new HotelBooking(b2);

        Console.WriteLine("\nDefault Booking:");
        Display(b1);

        Console.WriteLine("\nParameterized Booking:");
        Display(b2);

        Console.WriteLine("\nCopied Booking:");
        Display(b3);
    }

    static void Display(HotelBooking hb){
        Console.WriteLine("Guest Name : " + hb.GuestName);
        Console.WriteLine("Room Type  : " + hb.RoomType);
        Console.WriteLine("Nights     : " + hb.Nights);
    }
}

