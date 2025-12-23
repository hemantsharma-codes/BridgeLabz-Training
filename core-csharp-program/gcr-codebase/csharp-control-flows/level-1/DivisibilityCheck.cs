using System;
class DivisibilityCheck {
	static void Main(String[] args){

		Console.WriteLine("Enter the number to check divisible by 5 :");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("Is the number "+number+" divisible by 5? "+(number%5 == 0));
	}
}
		
