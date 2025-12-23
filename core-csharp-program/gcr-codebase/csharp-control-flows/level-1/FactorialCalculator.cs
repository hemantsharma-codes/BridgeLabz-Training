using System;
class FactorialCalculator{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		// checking the number is positive or not
		
		if(number > 0){

			int fact = 1;
			// calculating factorial

			while(number > 0){
				fact = fact*number;
				number--;
			}

			Console.WriteLine("The number is positive and the factorial is "+fact);
		}
		else{
			Console.WriteLine("The number is negative.");
		}
	}
}
