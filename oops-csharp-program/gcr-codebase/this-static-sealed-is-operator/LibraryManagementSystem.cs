using System;
internal class Book
 {
     public static string LibraryName;
     public string Title;
     public string Author;
     public readonly string ISBN;

     static Book()
     {
         LibraryName = "Classic Library";
     }
     public Book(string title,string author,string iSBN)
     {
         this.Title = title;
         this.Author = author;
         this.ISBN = iSBN;
     }

     public static void DisplayLibraryName()
     {
         Console.WriteLine("Library name is : " + LibraryName);
     }

     public override string ToString()
     {
         return $"\nTitle : {Title}\nAuthor : {Author}\nISBN : {ISBN}";
     }
 }
class LibraryManagementSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the title of the book : ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the author of the book : ");
        string author = Console.ReadLine();

        Console.WriteLine("Enter the ISBN of the book");
        string isbn = Console.ReadLine();

        Book book = new Book(title, author, isbn);
        Book.DisplayLibraryName();

        Console.WriteLine(book);
    }
}
