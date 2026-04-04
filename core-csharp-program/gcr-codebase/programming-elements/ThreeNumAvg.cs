using System;

public class ThreeNumAvg
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int avg = (num1 + num2 + num3) / 3;

        Console.WriteLine("Avg of three numbers: " + avg);
    }
}

