using System;

class LibraryDoublyLinkedList
{
    // Node class representing each book in the library
    class BookNode
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public BookNode Next;
        public BookNode Prev;

        // Constructor to initialize book details
        public BookNode(string title, string author, string genre, int bookID, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = bookID;
            IsAvailable = isAvailable;
            Next = null;
            Prev = null;
        }
    }

    static BookNode head = null;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 Add At Beginning");
            Console.WriteLine("2 Add At End");
            Console.WriteLine("3 Add At Position");
            Console.WriteLine("4 Remove By Book ID");
            Console.WriteLine("5 Search By Title");
            Console.WriteLine("6 Search By Author");
            Console.WriteLine("7 Update Availability");
            Console.WriteLine("8 Display Forward");
            Console.WriteLine("9 Display Reverse");
            Console.WriteLine("10 Count Books");
            Console.WriteLine("11 Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) AddAtBeginning();
            else if (choice == 2) AddAtEnd();
            else if (choice == 3) AddAtPosition();
            else if (choice == 4) RemoveByID();
            else if (choice == 5) SearchByTitle();
            else if (choice == 6) SearchByAuthor();
            else if (choice == 7) UpdateAvailability();
            else if (choice == 8) DisplayForward();
            else if (choice == 9) DisplayReverse();
            else if (choice == 10) CountBooks();
            else if (choice == 11) break;
        }
    }

    // Create a new book node by taking input from the user
    static BookNode CreateBook()
    {
        Console.WriteLine("Enter Book Title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Author");
        string author = Console.ReadLine();
        Console.WriteLine("Enter Genre");
        string genre = Console.ReadLine();
        Console.WriteLine("Enter Book ID");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Is Available (true/false)");
        bool available = bool.Parse(Console.ReadLine());

        return new BookNode(title, author, genre, id, available);
    }

    // Add a book at the beginning of the list
    static void AddAtBeginning()
    {
        BookNode newNode = CreateBook();
        if (head != null)
        {
            newNode.Next = head;
            head.Prev = newNode;
        }
        head = newNode;
    }

    // Add a book at the end of the list
    static void AddAtEnd()
    {
        BookNode newNode = CreateBook();
        if (head == null)
        {
            head = newNode;
            return;
        }

        BookNode temp = head;
        while (temp.Next != null) temp = temp.Next;

        temp.Next = newNode;
        newNode.Prev = temp;
    }

    // Add a book at a specific position
    static void AddAtPosition()
    {
        Console.WriteLine("Enter Position");
        int pos = int.Parse(Console.ReadLine());
        if (pos <= 1)
        {
            AddAtBeginning();
            return;
        }

        BookNode newNode = CreateBook();
        BookNode temp = head;

        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid Position");
            return;
        }

        newNode.Next = temp.Next;
        if (temp.Next != null) temp.Next.Prev = newNode;
        temp.Next = newNode;
        newNode.Prev = temp;
    }

    // Remove a book by its ID
    static void RemoveByID()
    {
        Console.WriteLine("Enter Book ID");
        int id = int.Parse(Console.ReadLine());
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookID == id)
            {
                if (temp.Prev != null) temp.Prev.Next = temp.Next;
                else head = temp.Next;

                if (temp.Next != null) temp.Next.Prev = temp.Prev;
                return;
            }
            temp = temp.Next;
        }
    }

    // Search books by title
    static void SearchByTitle()
    {
        Console.WriteLine("Enter Book Title");
        string title = Console.ReadLine();
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title == title)
            {
                PrintBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found) Console.WriteLine("No books found");
    }

    // Search books by author
    static void SearchByAuthor()
    {
        Console.WriteLine("Enter Author");
        string author = Console.ReadLine();
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Author == author)
            {
                PrintBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found) Console.WriteLine("No books found");
    }

    // Update the availability of a book
    static void UpdateAvailability()
    {
        Console.WriteLine("Enter Book ID");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Availability (true/false)");
        bool available = bool.Parse(Console.ReadLine());

        BookNode temp = head;
        while (temp != null)
        {
            if (temp.BookID == id)
            {
                temp.IsAvailable = available;
                return;
            }
            temp = temp.Next;
        }
    }

    // Display all books in forward order
    static void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Next;
        }
    }

    // Display all books in reverse order
    static void DisplayReverse()
    {
        if (head == null) return;
        BookNode temp = head;
        while (temp.Next != null) temp = temp.Next;

        while (temp != null)
        {
            PrintBook(temp);
            temp = temp.Prev;
        }
    }

    // Count total number of books
    static void CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine("Total Books: " + count);
    }

    // Print details of a single book
    static void PrintBook(BookNode node)
    {
        Console.WriteLine(node.BookID);
        Console.WriteLine(node.Title);
        Console.WriteLine(node.Author);
        Console.WriteLine(node.Genre);
        Console.WriteLine(node.IsAvailable);
    }
}
