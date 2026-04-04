using System;
class NaturalNumberSum{
	static int SumOfNaturalNumber(int n){

		int sum = 0;
		for(int i=0;i<n;i++){
			Console.WriteLine("Enter the natural number :");
			int number = int.Parse(Console.ReadLine());
			sum += number;
		}
		return sum;
	}
	static void Main(String[] args){

		// take input for n nautral numbers
		Console.WriteLine("Enter the number for n natural number :");
		int n = int.Parse(Console.ReadLine());

		// calling method
		int totalSum = SumOfNaturalNumber(n);

		Console.WriteLine("Sum of "+n+" natural numbers is "+totalSum);
	}
}
