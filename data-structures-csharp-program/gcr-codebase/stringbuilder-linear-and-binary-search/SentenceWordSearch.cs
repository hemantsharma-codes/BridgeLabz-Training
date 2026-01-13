using System;
class SentenceWordSearch
{
    static int FindSentence(string[] sentences, string word)
    {
        for (int i=0;i<sentences.Length;i++)
        {
            if (sentences[i].Contains(word))
            {
                return i;   // return index of first matching sentence
            }
        }

        return -1;   // word not found in any sentence
    }

    static void Main()
    {
        Console.WriteLine("Enter number of sentences:");
        int count = int.Parse(Console.ReadLine());

        string[] sentences = new string[count];

        for(int i=0;i<count;i++)
        {
            Console.Write("Enter sentence "+(i+1)+": ");
            sentences[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter word to search:");
        string searchWord = Console.ReadLine();

        int position = FindSentence(sentences, searchWord);

        if (position != -1)
        {
            Console.WriteLine("Word found in sentence:");
            Console.WriteLine(sentences[position]);
        }
        else
        {
            Console.WriteLine("Word not found in any sentence.");
        }
    }
}

