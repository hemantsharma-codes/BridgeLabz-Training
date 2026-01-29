using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.io_programming_csharp_program.csv_data_handling
{
    class CountCSVRows
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\golub\\Desktop\\BridgeLabzCopy\\BridgeLabzCopy\\BridgeLabzCopy\\io-programming-csharp-program\\csv-data-handling\\employees.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            int recordCount = lines.Length - 1;

            Console.WriteLine("Total Employee Records: " + recordCount);
        }
    }

}
