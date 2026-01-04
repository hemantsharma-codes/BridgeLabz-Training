using System;
class Book{
    private string title;
    private string author;
    private double price;
    private bool availability;

    // Parameterized constructor
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
        availability = true; // available by default
    }

    // Method to borrow a book
    public void BorrowBook(){
        if (availability){
            availability = false;
            Console.WriteLine("Book borrowed successfully.");
        }else{
            Console.WriteLine("Book is already borrowed.");
        }
    }

    // Display method
    public void DisplayBook(){
        Console.WriteLine("Title        : " + title);
        Console.WriteLine("Author       : " + author);
        Console.WriteLine("Price        : " + price);
        Console.WriteLine("Availability : " + (availability ? "Available" : "Not Available"));
    }
}

class LibraryDemo{
    static void Main(string[] args){
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        double price = double.Parse(Console.ReadLine());

        // Create book object using user input
        Book book = new Book(title, author, price);

        Console.WriteLine("\nBook Details:");
        book.DisplayBook();

        Console.WriteLine("\nBorrowing the Book...");
        book.BorrowBook();

        Console.WriteLine("\nBook Details After Borrowing:");
        book.DisplayBook();

        Console.WriteLine("\nTrying to Borrow Again:");
        book.BorrowBook();
    }
}

