internal interface IEmployee
{
	Employee AddEmployee();
	bool IsEmployeePresentOrAbsent(Employee employee);
	double CalculateDailyEmployeeWage(Employee employee);
	double CalculateWageOfMonth(Employee employee);
}
