using System;
using System.Text.RegularExpressions;
class ValidationLicensePlate
{
    static void Main()
    {
        Console.Write("Enter license plate: ");
        string plate = Console.ReadLine();

        string pattern = @"^[A-Z]{2}[0-9]{4}$";

        Console.WriteLine(
            Regex.IsMatch(plate, pattern) ? "Valid License Plate" : "Invalid License Plate"
        );
    }
}

