using System;
class ReverseNumber{
	static void Main(String[] args){
		
		// create a variable to take the input of number
		Console.WriteLine("Enter a number :");
		long number = long.Parse(Console.ReadLine());

		// count the number of digit
		int digit = 0;
		long temp = number;

		while(temp > 0){
			digit++;
			temp /= 10;
		}
		
		// create an array to store the digits of number
		int[] array = new int[digit];
		int idx = 0;
		while(number > 0){
			array[idx] = (int)number%10;
			idx++;
			number = number/10;
		}

		// display the element of array in reverse order

		idx = 0;
		Console.WriteLine("Reverse digits of number are :");
		while(idx < digit){
			Console.WriteLine(array[idx]+"");
			idx++;
		}
	}
}
