using System;
class GreatestFactorCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		// taking a variable greatestFactor and assigning it to 1
		int greatestFactor = 1;

		for(int i=number-1;i>=1;i--){
			
			if(number%i == 0){
				greatestFactor = i;
				break;
			}
		}

		Console.WriteLine("The greatest factor of the number is "+greatestFactor);
	}
}
