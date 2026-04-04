using System;
class BasicCalculator{
	static void Main(String[] args){

		Console.WriteLine("Enter the first number :");
		float num1 = float.Parse(Console.ReadLine());

		Console.WriteLine("Enter the second number :");
		float num2 = float.Parse(Console.ReadLine());

		float add = num1+num2;
		float sub = num1-num2;
		float mult = num1*num2;
		float div = num1/num2;

		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+num1+" and "+num2+" is "+add+", "+sub+", "+mult+", "+div);
	}
}
