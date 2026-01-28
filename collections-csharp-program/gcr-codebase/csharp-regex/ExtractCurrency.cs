using System;
using System.Text.RegularExpressions;
class ExtractCurrency
{
    static void Main()
    {
        string text = "The price is $45.99, and discount is $ 10.50.";

        string pattern = @"\$?\s?\d+\.\d{2}";

        foreach (Match match in Regex.Matches(text, pattern))
            Console.WriteLine(match.Value.Trim());
    }
}

