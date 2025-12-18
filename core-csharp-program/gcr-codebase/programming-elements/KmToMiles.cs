using System;

public class KmToMiles
{
    public static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        int km = int.Parse(Console.ReadLine());

        double miles = km * 0.621371;

        Console.WriteLine("Miles: " + miles);
    }
}

