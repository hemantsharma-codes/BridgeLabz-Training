using System;
class NumberComparison{
	static void Main(String[] args){

		// creating an array of size 5
		int[] numbers = new int[5];

		// taking the input for array
		for(int i=0;i<5;i++){
			numbers[i] = int.Parse(Console.ReadLine());
		}

		// comparison of numbers using for loop

		for(int i=0;i<5;i++){
			
			if(numbers[i] > 0){
				if(numbers[i]%2 == 0){
					Console.WriteLine(numbers[i]+" is even.");
				}
				else{
					Console.WriteLine(numbers[i]+" is odd.");
				}
			}
			else if(numbers[i] < 0){
				Console.WriteLine(numbers[i]+" is negative.");
			}
			else{
				Console.WriteLine(numbers[i]+" is zero.");
			}
		}

		// comparing first and last element of array
		if(numbers[0] > numbers[numbers.Length-1]){
			Console.WriteLine("First element of array is greater.");
		}
		else if(numbers[0] < numbers[numbers.Length-1]){
			Console.WriteLine("Last element of array is greater.");
		}
		else{
			Console.WriteLine("First and Last elements of array are equal.");
		}
	}
}
