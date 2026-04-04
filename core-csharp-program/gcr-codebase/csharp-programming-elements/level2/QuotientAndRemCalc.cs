using System;
class QuotientAndRemCalc{
	static void Main(String[] args){

		Console.WriteLine("Enter the first number :");
		int number1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the second number :");
		int number2 = int.Parse(Console.ReadLine());

		double quotient = (double) (number1/number2);
		int remainder = number1%number2;

		Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2);
	}
}
