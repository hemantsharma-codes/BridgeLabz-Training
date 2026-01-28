using System;
using System.Text.RegularExpressions;
class IPAddressValidation
{
    static void Main()
    {
        Console.Write("Enter IP address: ");
        string ip = Console.ReadLine();

        string pattern =
            @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}" +
            @"(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

        Console.WriteLine(
            Regex.IsMatch(ip, pattern) ? "Valid IP Address" : "Invalid IP Address"
        );
    }
}

