using System;
class SpringSeason{
	static void Main(String[] args){

		Console.WriteLine("Enter the month :");
		int month = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the day :");
		int day = int.Parse(Console.ReadLine());

		if((month >= 3 || day >= 20) || month == 4 || month == 5 || (month == 6 && day <= 20)){
			Console.WriteLine("Its a Spring Season");
	        }
		else{
			Console.WriteLine("Not a Spring Season");
	        }
	}
}
