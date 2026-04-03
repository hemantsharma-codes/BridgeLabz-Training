using System;
public class Employee{
	private string name;
	private int id;
	private int salary;

	public Employee(string name,int id,int salary){
		this.name = name;
		this.id = id;
		this.salary = salary;
	}
	static void Main(String[] args){
		Employee employee = new Employee("hemant",1,28000);

		Console.WriteLine("Details of employee : ");
		Console.WriteLine("Name : "+employee.name+", Id : "+employee.id+", Salary : "+employee.salary);
	}
}
