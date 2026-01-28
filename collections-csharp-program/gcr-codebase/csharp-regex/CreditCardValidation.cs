using System;
using System.Text.RegularExpressions;
class CreditCardValidation
{
    static void Main()
    {
        Console.Write("Enter card number: ");
        string card = Console.ReadLine();

        string visa = @"^4\d{15}$";
        string master = @"^5\d{15}$";

        if (Regex.IsMatch(card, visa))
            Console.WriteLine("Visa Card");
        else if (Regex.IsMatch(card, master))
            Console.WriteLine("MasterCard");
        else
            Console.WriteLine("Invalid Card");
    }
}

