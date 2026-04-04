using System;
class CountNumberDigits{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		int digitCount = 0;

		while(number > 0){

			digitCount++;
			number /= 10;

		}

		Console.WriteLine("The number of digits : "+digitCount);
	}
}
