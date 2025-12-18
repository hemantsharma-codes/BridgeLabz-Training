using System;

public class RectanglePeri
{
    public static void Main(string[] args)
    {
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());

        int perimeter = 2 * (length + width);

        Console.WriteLine(perimeter);
    }
}

