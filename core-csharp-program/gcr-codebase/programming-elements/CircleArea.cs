using System;
public class CircleArea
{
    public static void Main(string[] args)
    {
        Console.Write("Enter radius of the circle: ");
        float radius = float.Parse(Console.ReadLine());

        // Calculate area: π * r^2
        float area = (float)((22.0 / 7) * Math.Pow(radius, 2));

        Console.WriteLine("Area: " + area);
    }
}

