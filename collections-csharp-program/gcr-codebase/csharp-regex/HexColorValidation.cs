using System;
using System.Text.RegularExpressions;
class HexColorValidation
{
    static void Main()
    {
        Console.Write("Enter hex color code: ");
        string color = Console.ReadLine();

        string pattern = @"^#[0-9a-fA-F]{6}$";

        Console.WriteLine(
            Regex.IsMatch(color, pattern) ? "Valid Hex Color" : "Invalid Hex Color"
        );
    }
}

