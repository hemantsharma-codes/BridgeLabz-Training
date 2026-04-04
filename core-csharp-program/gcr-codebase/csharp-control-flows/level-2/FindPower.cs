using System;
class FindPower{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the power of the number :");
		int power = int.Parse(Console.ReadLine());

		// taking a variable of name result to assign the answer

		int result = 1;
		
		for(int i=1;i<=power;i++){

			result *= number;

		}

		Console.WriteLine("Result : "+result);
	}
}
