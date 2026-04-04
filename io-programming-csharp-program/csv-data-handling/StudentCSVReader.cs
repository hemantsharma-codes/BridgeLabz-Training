using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BridgeLabzCopy.io_programming_csharp_program.csv_data_handling
{
    class StudentCSVReader
    {
        static void Main()
        {
            string filePath = "C:\\Users\\golub\\Desktop\\BridgeLabzCopy\\BridgeLabzCopy\\BridgeLabzCopy\\io-programming-csharp-program\\csv-data-handling\\students.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("---- Student Details ----\n");

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] data = line.Split(',');

                string id = data[0];
                string name = data[1];
                string age = data[2];
                string marks = data[3];

                Console.WriteLine("Student ID   : " + id);
                Console.WriteLine("Name         : " + name);
                Console.WriteLine("Age          : " + age);
                Console.WriteLine("Marks        : " + marks);
                Console.WriteLine("---------------------------");
            }
        }
    }

}
