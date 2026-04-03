using EmployeeManagementSystem;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Employee emp1 = new FullTimeEmployee(101, "Hemant", 50000);
        emp1.AssignDepartment("IT");

        Employee emp2 = new PartTimeEmployee(102, "Aman", 80, 300);
        emp2.AssignDepartment("Support");

        employees.Add(emp1);
        employees.Add(emp2);

        // Polymorphism
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
