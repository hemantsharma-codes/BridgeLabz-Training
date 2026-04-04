using System;
class Calculator{
	static void Main(String[] args){

		Console.WriteLine("Enter the first and second number :");
		int first = int.Parse(Console.ReadLine());
		int second = int.Parse(Console.ReadLine());

		string op = Console.ReadLine();

		switch(op)
		{
			case "+":
				Console.WriteLine("Addition of two number : "+(first+second));
				break;
			case "-":
				Console.WriteLine("Subtraction of two number : "+(first-second));
				break;
			case "*":
				Console.WriteLine("Multiplication of two number : "+(first*second));
				break;
			case "/":
				Console.WriteLine("Division of two number :"+(first/second));
				break;
			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}
