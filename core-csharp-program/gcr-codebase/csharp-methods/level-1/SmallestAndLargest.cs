using System;
class SmallestAndLargest{
	static int FindSmallestNumber(int number1,int number2,int number3){
		if(number1 < number2 && number1 < number3){
			return number1;
		}
		else if(number2 < number1 && number2 < number3){
			return number2;
		}
		return number3;
	}
	static int FindLargestNumber(int number1,int number2,int number3){
		if(number1 > number2 && number1 > number3){
			return number1;
		}
		else if(number2 > number1 && number2 > number3){
			return number2;
		}
		return number3;
	}
	static void Main(String[] args){

		// take input for 3 numbers
		Console.WriteLine("Enter 3 number :");
		int number1 = int.Parse(Console.ReadLine());
		int number2 = int.Parse(Console.ReadLine());
		int number3 = int.Parse(Console.ReadLine());

		// method calling
		int smallest = FindSmallestNumber(number1,number2,number3);
		int largest = FindLargestNumber(number1,number2,number3);

		// display smallest and largest
		Console.WriteLine("The smallest in among three numbers :"+smallest);
		Console.WriteLine("The Largest in among three numbers :"+largest);
	}
}
