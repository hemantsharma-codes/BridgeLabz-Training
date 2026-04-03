using System;
using System.Text.RegularExpressions;
class ExtractLanguages
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but Go is new.";

        string pattern = @"\b(JavaScript|Java|Python|Go)\b";

        foreach (Match match in Regex.Matches(text, pattern))
            Console.WriteLine(match.Value);
    }
}

