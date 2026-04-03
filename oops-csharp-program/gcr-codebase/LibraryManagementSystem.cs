using System;
class Book{
    // Superclass attributes
    protected string title;
    protected int publicationYear;

    // Constructor
    public Book(string title, int publicationYear){
        this.title = title;
        this.publicationYear = publicationYear;
    }

    // Method to display book info
    public virtual void DisplayInfo(){
        Console.WriteLine("Book Title        : " + title);
        Console.WriteLine("Publication Year : " + publicationYear);
    }
}

// Subclass
class Author : Book{
    // Additional attributes
    private string name;
    private string bio;

    // Constructor (calls base class constructor)
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear){
        this.name = name;
        this.bio = bio;
    }

    // Display complete info (Book + Author)
    public override void DisplayInfo(){
        base.DisplayInfo(); // call Book's method
        Console.WriteLine("Author Name       : " + name);
        Console.WriteLine("Author Bio        : " + bio);
    }
}

class LibraryManagementSystem{
    static void Main(string[] args){
        Author a1 = new Author(
            "Clean Code",
            2008,
            "Robert C. Martin",
            "Software engineer and best-selling author"
        );

        Console.WriteLine("Book & Author Details:");
        a1.DisplayInfo();
    }
}

