using System;
class NumberChecker{
	static int CheckNumber(int number){

		if(number > 0){
			return 1;
		}
		else if(number < 0){
			return -1;
		}
		return 0;
	}
	static void Main(String[] args){

		// take a input for a number
		Console.WriteLine("Please enter a number :");
		int number = int.Parse(Console.ReadLine());

		// call method
		int numberStatus = CheckNumber(number);

		// display result
		Console.WriteLine(numberStatus);
	}
}
