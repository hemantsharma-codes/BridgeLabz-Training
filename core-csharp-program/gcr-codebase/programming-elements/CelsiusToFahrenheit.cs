using System;
public class CelsiusToFahrenheit
{
    public static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit: " + fahrenheit);
    }
}

