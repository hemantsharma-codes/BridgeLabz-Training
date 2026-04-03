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
            
    public double CalculateDailyEmployeeWage(Employee employee)
    {
            // assume 8 hours for part time employee and 16 hours for full time employee
            int partTimeEmployeeWorkingHour = 8;
            int fullTimeEmployeeWorkingHour = 16;

            if (employee.GetEmployeeType() == "Part time")
            {
                double employeeHalfDayWage = employee.GetHourlyRate() * partTimeEmployeeWorkingHour;
                return employeeHalfDayWage;
            }
            double employeeFullDayWage = employee.GetHourlyRate() * fullTimeEmployeeWorkingHour;
            return employeeFullDayWage;
    }
    public double CalculateWageOfMonth(Employee employee)
    {
            // 8 hours for part time employee and 16 hour for full time employee
            // 20 days in a month
            int partTimeEmployeeWorkingHour = 8;
            int fullTimeEmployeeWorkingHour = 16;
            int daysInMonth = 20;
            if(employee.GetEmployeeType() == "Part time")
            {
                double partTimeEmployeeMonthWage = employee.GetHourlyRate() * partTimeEmployeeWorkingHour * daysInMonth;
                return partTimeEmployeeMonthWage;
            }
            double fullTimeEmployeeMonthWage = employee.GetHourlyRate() * fullTimeEmployeeWorkingHour * daysInMonth;
            return fullTimeEmployeeMonthWage;
    }
}

