using System;
using System.IO;
using System.Collections.Generic;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class WordCountProgram
    {
        static void Main()
        {
            Console.WriteLine("Enter file path:");
            string filePath = Console.ReadLine();

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                Dictionary<string, int> wordCount = CountWords(filePath);
                DisplayTopFiveWords(wordCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        // Utility method to count words using Dictionary
        static Dictionary<string, int> CountWords(string path)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            StreamReader reader = new StreamReader(path);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                // Split line into words
                string[] splitWords = line.Split(
                    new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string word in splitWords)
                {
                    string lowerWord = word.ToLower();

                    if (words.ContainsKey(lowerWord))
                    {
                        words[lowerWord]++;
                    }
                    else
                    {
                        words.Add(lowerWord, 1);
                    }
                }
            }

            reader.Close();
            return words;
        }

        // Utility method to display top 5 frequent words
        static void DisplayTopFiveWords(Dictionary<string, int> words)
        {
            Console.WriteLine("\nTop 5 most frequent words:\n");

            for (int i = 0; i < 5; i++)
            {
                string maxWord = null;
                int maxCount = 0;

                foreach (var pair in words)
                {
                    if (pair.Value > maxCount)
                    {
                        maxCount = pair.Value;
                        maxWord = pair.Key;
                    }
                }

                if (maxWord == null)
                {
                    break;
                }

                Console.WriteLine(maxWord + " : " + maxCount);
                words.Remove(maxWord);
            }
        }
    }
}
