using System;
class Employee{
    public int employeeID;
    protected string department;
    private double salary;

    // Constructor
    public Employee(int employeeID, string department, double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to modify salary
    public void SetSalary(double salary){
        this.salary = salary;
    }

    // Public method to get salary
    public double GetSalary(){
        return salary;
    }
}

// Subclass to demonstrate access modifiers
class Manager : Employee{
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary){
    }
    public void DisplayManagerDetails(){
        Console.WriteLine("Employee ID : " + employeeID);     // public
        Console.WriteLine("Department  : " + department);      // protected
        Console.WriteLine("Salary      : " + GetSalary());     // private via method
    }
}
class EmployeeRecords{
    static void Main(string[] args){
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());

        Manager mgr = new Manager(id, dept, salary);

        Console.WriteLine("\nManager Details:");
        mgr.DisplayManagerDetails();

        Console.Write("\nEnter New Salary: ");
        double newSalary = double.Parse(Console.ReadLine());
        mgr.SetSalary(newSalary);

        Console.WriteLine("\nAfter Salary Update:");
        mgr.DisplayManagerDetails();
    }
}

