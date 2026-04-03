internal class Employee{
    private static int counter = 0;
    private int EmployeeId;
    private string EmployeeName; // member variable
    private double EmployeeHourlyRate;
    private string EmployeeType;
    private bool IsPresent;

    // getter and setter
    public int GetId()
    {
        return this.EmployeeId;
    }
    public string GetName()
    {
        return this.EmployeeName;
    }

    public double GetHourlyRate()
    {
        return this.EmployeeHourlyRate;
    }
    public string GetEmployeeType()
    {
        return this.EmployeeType;
    }
    public bool GetIsPresent()
    {
        return this.IsPresent;
    }
    // setter for presentOrAbsent
    public void SetIsPresent(bool status)
    {
        this.IsPresent = status;
    }

    public Employee(string name, double hourlyRate, string employeeType, bool IsPresent)
    {
        this.EmployeeId = ++counter;
        this.EmployeeName = name;
        this.EmployeeHourlyRate = hourlyRate;
        this.EmployeeType = employeeType;
        this.IsPresent = IsPresent;
    }

    public override string ToString()
    {
        return $"\nEmployee Id : {EmployeeId}\nEmployee Name : {EmployeeName}\nEmployee hourly rate : {EmployeeHourlyRate}\nEmployee type : {EmployeeType}\nEmployee status : {IsPresent}";
    }
}
