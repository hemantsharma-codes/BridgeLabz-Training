using System;
class TotalIncomeCalculator{
	static void Main(String[] args){

		Console.WriteLine("Enter the salary of person :");
		int salary = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the bonus of the person :");
		int bonus = int.Parse(Console.ReadLine());

		int totalIncome = salary+bonus;

		Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+totalIncome);
	}
}
