using System;
class SpringSeason{
	static int CheckSpringSeason(int month,int day){

		if((day >= 20 && month == 3) || (day <= 20 && month == 6) || month == 4 || month == 5){
			return 1;
		}
		return -1;
		
	}
	static void Main(String[] args){
		// take a input for month
		Console.WriteLine("Enter the month and day :");
		int month = int.Parse(Console.ReadLine());
		int day = int.Parse(Console.ReadLine());

		// calling method
		int status = CheckSpringSeason(month,day);
		
		// display result
		if(status == 1){
			Console.WriteLine("Its a Spring Season.");
		}
		else{
			Console.WriteLine("Its not a Spring Season.");
		}
	}
}
