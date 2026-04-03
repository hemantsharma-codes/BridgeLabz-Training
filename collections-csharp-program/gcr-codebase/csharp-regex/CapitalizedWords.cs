using System;
using System.Text.RegularExpressions;
class CapitalizedWords
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        string pattern = @"\b[A-Z][a-z]*\b";

        foreach (Match match in Regex.Matches(text, pattern))
            Console.WriteLine(match.Value);
    }
}

