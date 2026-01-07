using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public abstract class Employee : IDepartment
    {
        // Encapsulated fields
        private int employeeId;
        private string name;
        private double baseSalary;
        private string department;

        // Properties (Encapsulation)
        public int EmployeeId
        {
            get { return employeeId; }
            protected set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            protected set { baseSalary = value; }
        }

        // Constructor
        public Employee(int id, string name, double baseSalary)
        {
            EmployeeId = id;
            Name = name;
            BaseSalary = baseSalary;
        }

        // Abstract method
        public abstract double CalculateSalary();

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
            Console.WriteLine("---------------------------");
        }

        // Interface methods
        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

}
