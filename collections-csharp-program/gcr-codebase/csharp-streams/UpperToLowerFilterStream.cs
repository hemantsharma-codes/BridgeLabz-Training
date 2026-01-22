using System;
using System.IO;
using System.Text;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class UpperToLowerFilterStream
    {
        static void Main()
        {
            Console.WriteLine("Enter source file path:");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("Enter destination file path:");
            string destinationPath = Console.ReadLine();

            try
            {
                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                ConvertUpperToLower(sourcePath, destinationPath);
                Console.WriteLine("File converted and saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        // Utility method to convert uppercase to lowercase
        static void ConvertUpperToLower(string source, string destination)
        {
            // File streams
            FileStream readFile = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream writeFile = new FileStream(destination, FileMode.Create, FileAccess.Write);

            // Buffered streams for performance
            BufferedStream bufferedRead = new BufferedStream(readFile);
            BufferedStream bufferedWrite = new BufferedStream(writeFile);

            // StreamReader and StreamWriter with UTF-8 encoding
            StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8);
            StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }

            writer.Flush();

            reader.Close();
            writer.Close();
            bufferedRead.Close();
            bufferedWrite.Close();
            readFile.Close();
            writeFile.Close();
        }
    }
}
