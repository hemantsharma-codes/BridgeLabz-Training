using System;
	class EmployeeBonus{
		static void Main(String[] args){

			Console.WriteLine("Enter the salary of employee :");
			int salary = int.Parse(Console.ReadLine());


			Console.WriteLine("Enter the year of service :");
			int year = int.Parse(Console.ReadLine());

			if(year > 5){
				int bonusAmount = salary/20;
				
				Console.WriteLine("The bonus amount of employee : "+bonusAmount);
			}
		}
	}

