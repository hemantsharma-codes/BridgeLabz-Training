using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test.";

        string pattern = @"\b(\w+)\s+\1\b";

        foreach (Match match in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
            Console.WriteLine(match.Groups[1].Value);
    }
}

