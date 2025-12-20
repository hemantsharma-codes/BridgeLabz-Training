using System;
class TemperatureConversion
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheitResult = (celsius * 9.0 / 5.0) + 32;

        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheitResult+" Fahrenheit");
    }
}

