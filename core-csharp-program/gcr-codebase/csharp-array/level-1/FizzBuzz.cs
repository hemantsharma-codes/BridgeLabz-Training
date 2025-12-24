using System;
class FizzBuzz{
	static void Main(String[] args){

		// take a input of number
		Console.WriteLine("Enter a number :");
		int number = int.Parse(Console.ReadLine());

		// create a string array
		string[] array = new string[number+1];

		// check for positive integer
		if(number <= 0){
			Console.Error.WriteLine("Please enter a poistive number.");
			Environment.Exit(0);
		}


		// loop form 0 to number

		for(int i=0;i<=number;i++){
			
			if(i == 0){
				array[i] = "0";
			}
			else if(i%5 == 0 && i%3 == 0){
				array[i] = "FizzBuzz";
			}
			else if(i%3 == 0){
				array[i] = "Fizz";
			}
			else if(i%5 == 0){
				array[i] = "Buzz";
			}
			else{
				array[i] = i.ToString();
			}
		}

		// display result with position

		for(int i=0;i<array.Length;i++){
			Console.WriteLine("Position "+i+" = "+array[i]);
		}
	}
}
