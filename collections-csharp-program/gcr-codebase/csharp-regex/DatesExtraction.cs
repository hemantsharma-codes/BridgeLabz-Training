using System;
using System.Text.RegularExpressions;
class DatesExtraction
{
    static void Main()
    {
        string text = "The events are on 12/05/2023, 15/08/2024, and 29/02/2020.";

        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        foreach (Match match in Regex.Matches(text, pattern))
            Console.WriteLine(match.Value);
    }
}

