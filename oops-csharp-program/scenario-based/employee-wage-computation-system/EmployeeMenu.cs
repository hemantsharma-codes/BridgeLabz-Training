sealed class EmployeeMenu
{

    private readonly IEmployee EmployeeUtility;
    static List<Employee> employeeList = new List<Employee>();

    public EmployeeMenu()
    {
        EmployeeUtility = new EmployeeUtilityImpl();
    }
    public void EmployeeChoice()
    {
        Console.WriteLine("\nWelcome to Employee Wage Computation System \n");

        Console.WriteLine("\n1.Add an employee.");
        Console.WriteLine("2. Check wheather an employee present or not.");
        Console.WriteLine("3. Calculate daily employee wage.");
        Console.WriteLine("4. Calculate wages for a month.");
        Console.WriteLine("5. Exit");

        while (true)
        {
            Console.WriteLine("\nEnter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Employee employee = EmployeeUtility.AddEmployee();
                    employeeList.Add(employee);
                    break;
                case 2:
                    foreach (Employee emp in employeeList)
                    {
                        bool status = EmployeeUtility.IsEmployeePresentOrAbsent(emp);
                        Console.WriteLine($"{emp.GetName()} is {(status ? "Present" : "Absent")}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting.....");
                    return;
            }
        }
    }
}
