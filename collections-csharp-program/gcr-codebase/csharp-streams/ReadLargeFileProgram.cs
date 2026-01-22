using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class ReadLargeFileProgram
    {
        static void Main(string[] args)
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

                ReadFileLineByLine(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        // Utility method to read large file line by line
        static void ReadFileLineByLine(string path)
        {
            StreamReader reader = new StreamReader(path);
            string line;

            Console.WriteLine("\nLines containing word 'error':\n");

            while ((line = reader.ReadLine()) != null)
            {
                // Case-insensitive check
                if (line.ToLower().Contains("error"))
                {
                    Console.WriteLine(line);
                }
            }

            reader.Close();
        }
    }

}
