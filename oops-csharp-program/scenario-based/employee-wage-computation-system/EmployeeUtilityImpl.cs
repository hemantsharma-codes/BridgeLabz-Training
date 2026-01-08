internal class EmployeeUtilityImpl : IEmployee
{
    //private Employee employee;


    public Employee AddEmployee()
    {
        Console.WriteLine("Enter the name of the employee : ");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine("Enter the hourly rate of employee : ");
        double hourlyRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the employee type (Full time / Half time) : ");
        string type = Console.ReadLine() ?? "";

        // Assuming employee is present while adding
        bool isPresent = false;

        Employee employee = new Employee(name, hourlyRate, type, isPresent);

        Console.WriteLine("\nEmployee added successfully!");
        Console.WriteLine(employee);

        return employee;
    }
    public bool IsEmployeePresentOrAbsent(Employee employee)
    {
	    Random random = new Random();
            bool isPresent = random.Next(0, 2) == 1;

            employee.SetIsPresent(isPresent);
            return isPresent;
    }
}

