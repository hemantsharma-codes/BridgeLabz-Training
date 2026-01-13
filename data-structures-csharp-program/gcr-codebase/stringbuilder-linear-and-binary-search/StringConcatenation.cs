using System;
using System.Text;
class StringConcatenation
{
    static string JoinStrings(string[] words)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            builder.Append(words[i]);
        }

        return builder.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter number of strings:");
        int n = int.Parse(Console.ReadLine());

        string[] inputStrings = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string " + (i + 1) + ": ");
            inputStrings[i] = Console.ReadLine();
        }

        string finalResult = JoinStrings(inputStrings);

        Console.WriteLine("Concatenated String:");
        Console.WriteLine(finalResult);
    }
}

