using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class FileHandlingProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source file path:");
            string sourcePath = Console.ReadLine();

            Console.WriteLine("Enter destination file path:");
            string destinationPath = Console.ReadLine();

            // Check source file
            if (!IsSourceFileExists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Copy content from source to destination
            ReadAndWriteFile(sourcePath, destinationPath);

            Console.WriteLine("File content copied successfully.");
        }

        // Utility method to check source file
        static bool IsSourceFileExists(string path)
        {
            return File.Exists(path);
        }

        // Utility method to read from source and write to destination
        static void ReadAndWriteFile(string sourcePath, string destinationPath)
        {
            FileStream readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
            FileStream writeStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

            int data;

            // Read byte by byte and write to new file
            while ((data = readStream.ReadByte()) != -1)
            {
                writeStream.WriteByte((byte)data);
            }

            // Close streams
            readStream.Close();
            writeStream.Close();
        }
    }
}
