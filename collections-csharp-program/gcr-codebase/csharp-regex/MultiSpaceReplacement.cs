using System;
using System.Text.RegularExpressions;
class MultiSpaceReplacement
{
    static void Main()
    {
        string input = "This   is    an   example.";

        string result = Regex.Replace(input, @"\s+", " ");

        Console.WriteLine(result);
    }
}

