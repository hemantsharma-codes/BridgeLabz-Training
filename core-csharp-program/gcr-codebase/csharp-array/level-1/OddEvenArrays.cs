using System;
class OddEvenArrays{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		// check for natural number
		if(number <= 0){
			Console.Error.WriteLine("Please enter a natural number.");
			Environment.Exit(0);
		}

		// create arrays

		int size = number/2 + 1;
		int[] even = new int[size];
		int[] odd = new int[size];

		// take index variabl and assign with zero
		int evenIdx = 0;
		int oddIdx = 0;

		for(int i=1;i<=number;i++){

			if(i%2 == 0){
				even[evenIdx] = i;
				evenIdx++;
			}
			else{
				odd[oddIdx] = i;
				oddIdx++;
			}
		}

		// print the even numbers
		Console.WriteLine("The even numbers are :");
		evenIdx -= 1;
		while(evenIdx >= 0){
			Console.WriteLine(even[evenIdx]);
			evenIdx--;
		}

		// print the odd numbers
		Console.WriteLine("The odd numbers are :");
		oddIdx -= 1;
		while(oddIdx >=0){
			Console.WriteLine(odd[oddIdx]);
			oddIdx--;
		}
	}
}
