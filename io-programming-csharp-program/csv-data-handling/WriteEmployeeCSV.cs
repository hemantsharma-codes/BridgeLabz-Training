using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.io_programming_csharp_program.csv_data_handling
{
    class WriteEmployeeCSV
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\golub\\Desktop\\BridgeLabzCopy\\BridgeLabzCopy\\BridgeLabzCopy\\io-programming-csharp-program\\csv-data-handling\\employees.csv";

            // Create employee data
            string[] employeeData =
            {
            "ID,Name,Department,Salary",
            "1,Rahul,IT,50000",
            "2,Aditi,HR,45000",
            "3,Suresh,Finance,55000",
            "4,Neha,Marketing,48000",
            "5,Aman,IT,60000"
        };

            // Write data to CSV file
            File.WriteAllLines(filePath, employeeData);

            Console.WriteLine("Employee data written successfully to CSV file.");
        }
    }

}
