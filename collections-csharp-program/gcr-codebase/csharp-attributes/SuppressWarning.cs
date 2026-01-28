using System;
using System.Collections;

class SuppressWarning
{
    static void Main(string[] args)
    {
        // Disable compiler warning for obsolete or unchecked usage
#pragma warning disable CS0618

        // Non-generic ArrayList
        ArrayList itemsList = new ArrayList();

        itemsList.Add(10);          // integer
        itemsList.Add("Hello");     // string
        itemsList.Add(25.5);        // double

        // Enable warning again
#pragma warning restore CS0618

        Console.WriteLine("Items in ArrayList:");

        foreach (object item in itemsList)
        {
            Console.WriteLine(item);
        }
    }
}

