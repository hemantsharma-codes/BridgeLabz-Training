using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    class UserInfoFileProgram
    {
        static void Main(string[] args)
        {
            try
            {
                // Read user details
                string name = ReadInput("Enter your name: ");
                string age = ReadInput("Enter your age: ");
                string language = ReadInput("Enter your favorite programming language: ");

                // Save details to file
                SaveToFile(name, age, language);

                Console.WriteLine("User information saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Utility method to read input using StreamReader
        static string ReadInput(string message)
        {
            Console.Write(message);

            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            string input = reader.ReadLine();

            return input;
        }

        // Utility method to write data into file using StreamWriter
        static void SaveToFile(string name, string age, string language)
        {
            string filePath = "UserInfo.txt";

            StreamWriter writer = new StreamWriter(filePath, true);

            writer.WriteLine("Name : " + name);
            writer.WriteLine("Age  : " + age);
            writer.WriteLine("Favorite Language : " + language);
            writer.WriteLine("-------------------------");

            writer.Close();
        }
    }

}
