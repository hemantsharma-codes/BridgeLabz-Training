using System;
class LargestNumberCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the first number :");
		int number1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the second number :");
                int number2 = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the third number :");
                int number3 = int.Parse(Console.ReadLine());

		Console.WriteLine("Is the first number the largest? "+(number1 > number2 && number1 > number3));
		Console.WriteLine("Is the second number the largest? "+(number2 > number1 && number2 > number3));
		Console.WriteLine("Is the third number the largest? "+(number3 > number1 && number3 > number2));

	}
}


