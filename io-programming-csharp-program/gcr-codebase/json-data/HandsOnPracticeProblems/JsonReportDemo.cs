using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class JsonReportDemo
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "IT" },
            new Employee { Id = 2, Name = "Bob", Department = "HR" },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance" }
        };

        string jsonReport = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine(jsonReport);
    }
}
