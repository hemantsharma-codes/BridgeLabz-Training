using System;

class MovieDoublyLinkedList
{
    // Node class representing each movie record in the doubly linked list
    class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public MovieNode Next;
        public MovieNode Prev;

        // Constructor to initialize movie details
        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

    // Head of the doubly linked list
    static MovieNode head = null;

    // Entry point of the program
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 Add At Beginning");
            Console.WriteLine("2 Add At End");
            Console.WriteLine("3 Add At Position");
            Console.WriteLine("4 Remove By Title");
            Console.WriteLine("5 Search By Director");
            Console.WriteLine("6 Search By Rating");
            Console.WriteLine("7 Update Rating");
            Console.WriteLine("8 Display Forward");
            Console.WriteLine("9 Display Reverse");
            Console.WriteLine("10 Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) AddAtBeginning();
            else if (choice == 2) AddAtEnd();
            else if (choice == 3) AddAtPosition();
            else if (choice == 4) RemoveByTitle();
            else if (choice == 5) SearchByDirector();
            else if (choice == 6) SearchByRating();
            else if (choice == 7) UpdateRating();
            else if (choice == 8) DisplayForward();
            else if (choice == 9) DisplayReverse();
            else if (choice == 10) break;
        }
    }

    // Create a new movie node by taking input from the user
    static MovieNode CreateMovie()
    {
        Console.WriteLine("Enter Movie Title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Director");
        string director = Console.ReadLine();
        Console.WriteLine("Enter Year of Release");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Rating");
        double rating = double.Parse(Console.ReadLine());

        return new MovieNode(title, director, year, rating);
    }

    // Add a movie at the beginning of the list
    static void AddAtBeginning()
    {
        MovieNode newNode = CreateMovie();
        if (head != null)
        {
            newNode.Next = head;
            head.Prev = newNode;
        }
        head = newNode;
    }

    // Add a movie at the end of the list
    static void AddAtEnd()
    {
        MovieNode newNode = CreateMovie();
        if (head == null)
        {
            head = newNode;
            return;
        }

        MovieNode temp = head;
        while (temp.Next != null) temp = temp.Next;

        temp.Next = newNode;
        newNode.Prev = temp;
    }

    // Add a movie at a specific position in the list
    static void AddAtPosition()
    {
        Console.WriteLine("Enter Position");
        int pos = int.Parse(Console.ReadLine());
        if (pos <= 1)
        {
            AddAtBeginning();
            return;
        }

        MovieNode newNode = CreateMovie();
        MovieNode temp = head;

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

    // Remove a movie from the list by its title
    static void RemoveByTitle()
    {
        Console.WriteLine("Enter Movie Title");
        string title = Console.ReadLine();
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title == title)
            {
                if (temp.Prev != null) temp.Prev.Next = temp.Next;
                else head = temp.Next;

                if (temp.Next != null) temp.Next.Prev = temp.Prev;
                return;
            }
            temp = temp.Next;
        }
    }

    // Search movies by director name
    static void SearchByDirector()
    {
        Console.WriteLine("Enter Director");
        string director = Console.ReadLine();
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director == director)
            {
                PrintMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found) Console.WriteLine("No movies found");
    }

    // Search movies by exact rating
    static void SearchByRating()
    {
        Console.WriteLine("Enter Rating");
        double rating = double.Parse(Console.ReadLine());
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                PrintMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found) Console.WriteLine("No movies found");
    }

    // Update the rating of a movie by its title
    static void UpdateRating()
    {
        Console.WriteLine("Enter Movie Title");
        string title = Console.ReadLine();
        Console.WriteLine("Enter New Rating");
        double rating = double.Parse(Console.ReadLine());

        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = rating;
                return;
            }
            temp = temp.Next;
        }
    }

    // Display all movies from head to end
    static void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            PrintMovie(temp);
            temp = temp.Next;
        }
    }

    // Display all movies from end to head
    static void DisplayReverse()
    {
        if (head == null) return;
        MovieNode temp = head;
        while (temp.Next != null) temp = temp.Next;

        while (temp != null)
        {
            PrintMovie(temp);
            temp = temp.Prev;
        }
    }

    // Print details of a single movie node
    static void PrintMovie(MovieNode node)
    {
        Console.WriteLine(node.Title);
        Console.WriteLine(node.Director);
        Console.WriteLine(node.Year);
        Console.WriteLine(node.Rating);
    }
}
