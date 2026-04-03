using System;
internal class Employee
{
     internal static string CompanyName;
     internal static int TotalEmployeeCount;
     internal string Name;
     internal readonly int Id;
     internal string Designation;

     static Employee()
     {
         CompanyName = "XYZ";
     }
     internal Employee(string name,int id,string designation)
     {
         this.Name = name;
         this.Id = id;
         this.Designation = designation;
         TotalEmployeeCount += 1;
     }
     internal static void DisplayTotalEmployee()
     {
         Console.WriteLine("The total number of employees are : "+TotalEmployeeCount);
     }

     public override string ToString()
     {
         return $"\nName : {Name}\nId : {Id}\nDesignation : {Designation}";
     }

 }
public class EmployeeManagementSystem
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of the employee : ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the Id of the employee");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the designation of the employee : ");
        string designation = Console.ReadLine();

        Employee employee = new Employee(name, id, designation);

        Employee.DisplayTotalEmployee();
        if(employee is Employee)
        {
            Console.WriteLine(employee);
        }
    }
}
