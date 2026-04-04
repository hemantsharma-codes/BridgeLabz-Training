using System;

public class PowerCalc
{
    public static void Main(string[] args)
    {
        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        double power = Math.Pow(baseNum, exponent);

        Console.WriteLine("Power: " + power);
    }
}

