using System;
class MultiplicationSystem{
	static void Main(String[] args){

		// taking a number as input
		Console.WriteLine("Enter a number :");
		int number = int.Parse(Console.ReadLine());

		// creating an array of size 10 to store result of multiplication table

		int[] result = new int[10];
		
		// storing the result into array
		for(int i=0;i<10;i++){
			result[i] = (i+1)*number;
		}

		// display the result
		
		for(int i=0;i<10;i++){
			Console.WriteLine(number+" * "+(i+1)+" = "+result[i]);
		}
	}
}
