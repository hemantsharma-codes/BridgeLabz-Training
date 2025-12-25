using System;
class LeapYearChecker{
	static bool CheckLeapYear(int year){
		if((year%4 == 0 && year%100 != 0) || year%400 == 0){
			return true;
		}
		return false;
	}
	static void Main(string[] args){

		Console.WriteLine("Please enter a year :");
		int year = int.Parse(Console.ReadLine());

		// call method
		bool flag = CheckLeapYear(year);

		if(flag == true){
			Console.WriteLine(year+" is a leap year.");
		}
		else{
			Console.WriteLine(year+" is not a leap year.");
		}
	}
}
