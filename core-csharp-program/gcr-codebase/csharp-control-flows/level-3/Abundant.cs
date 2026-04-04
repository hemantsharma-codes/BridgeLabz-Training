using System;
class Abundant{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		int divisorSum = 0;

		for(int i=1;i<number;i++){
			
			if(number%i == 0){
				divisorSum += i;
			}
		}

		if(divisorSum > number){
			Console.WriteLine(number+" is an Abundant number.");
		}
		else{
			Console.WriteLine(number+" is not an Abundant number.");
		}
	}
}
