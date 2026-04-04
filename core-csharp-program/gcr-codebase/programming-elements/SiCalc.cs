using System;

public class SiCalc
{
    public static void Main(string[] args)
    {
        Console.Write("Enter principal: ");
        int principal = int.Parse(Console.ReadLine());

        Console.Write("Enter rate: ");
        int rate = int.Parse(Console.ReadLine());

        Console.Write("Enter time: ");
        int time = int.Parse(Console.ReadLine());

        double interest = (principal * rate * time) / 100.0;

        Console.WriteLine(interest);
    }
}

