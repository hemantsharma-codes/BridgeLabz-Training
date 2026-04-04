using System;
class LeapYear{
	static void Main(String[] args){
		
		Console.WriteLine("Enter the year :");
		int year = int.Parse(Console.ReadLine());

		if(year%400 == 0){
			Console.WriteLine(year+" is a leap year.");
		}
		else if(year%4 == 0 && year%100 != 0){
			Console.WriteLine(year+" is a leap year.");
		}
		else{
			Console.WriteLine(year+" is not a leap year.");
		}
	}
}

