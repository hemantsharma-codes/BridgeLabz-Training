using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
{
    [Serializable]
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }

    class ObjectSerialization
    {
        static string filePath = "employees.dat";

        static void Main()
        {
            try
            {
                List<Employee> employees = CreateEmployeeList();
                SaveEmployeesToFile(employees);
                ReadEmployeesFromFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        // Utility method to create employee data
        static List<Employee> CreateEmployeeList()
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 50000 });
            list.Add(new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 45000 });
            list.Add(new Employee { Id = 3, Name = "Ravi", Department = "Finance", Salary = 60000 });

            return list;
        }

        // Utility method to serialize employee list
        static void SaveEmployeesToFile(List<Employee> employees)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, employees);
            fs.Close();

            Console.WriteLine("Employee data saved successfully.\n");
        }

        // Utility method to deserialize and display employee list
        static void ReadEmployeesFromFile()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            List<Employee> employees =
                (List<Employee>)formatter.Deserialize(fs);

            fs.Close();

            Console.WriteLine("---- Employee Details ----");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(
                    "Id: " + emp.Id +
                    ", Name: " + emp.Name +
                    ", Department: " + emp.Department +
                    ", Salary: " + emp.Salary
                );
            }
        }
    }
}
