using System;
class SwapNumber{
	static void Main(String[] args){

		Console.WriteLine("Enter the first number :");
		int number1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the second number :");
		int number2 = int.Parse(Console.ReadLine());

		int temp = number1;
		number1 = number2;
		number2 = number1;

		Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
	}
}
