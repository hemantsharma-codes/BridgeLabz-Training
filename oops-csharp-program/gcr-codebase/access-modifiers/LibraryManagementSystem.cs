using System;
class Book{
    public string ISBN;
    protected string title;
    private string author;

    // Constructor
    public Book(string isbn, string title, string author){
        ISBN = isbn;
        this.title = title;
        this.author = author;
    }

    // Setter for private author
    public void SetAuthor(string author){
        this.author = author;
    }

    // Getter for private author
    public string GetAuthor(){
        return author;
    }
}

// Subclass to demonstrate access modifiers
class EBook : Book{
    private double fileSize; // in MB

    public EBook(string isbn, string title, string author, double fileSize)
        : base(isbn, title, author){
        this.fileSize = fileSize;
    }

    public void DisplayEBookDetails(){
        Console.WriteLine("ISBN      : " + ISBN);
        Console.WriteLine("Title     : " + title);
        Console.WriteLine("Author    : " + GetAuthor());
        Console.WriteLine("File Size : " + fileSize + " MB");
    }
}

class LibraryManagementSystem{
    static void Main(string[] args){
        EBook eb = new EBook("978-0132350884", "Clean Code", "Robert C. Martin", 5.6);

        Console.WriteLine("EBook Details:");
        eb.DisplayEBookDetails();

	// Modify private author using setter
        eb.SetAuthor("Uncle Bob");

        Console.WriteLine("\nAfter Updating Author:");
        eb.DisplayEBookDetails();
    }
}

