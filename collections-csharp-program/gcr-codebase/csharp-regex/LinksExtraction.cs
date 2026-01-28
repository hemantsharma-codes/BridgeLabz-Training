using System;
using System.Text.RegularExpressions;
class LinksExtraction
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org";

        string pattern = @"https?://[^\s]+";

        foreach (Match match in Regex.Matches(text, pattern))
            Console.WriteLine(match.Value);
    }
}

