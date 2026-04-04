using System;
class PrimeNumberCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		bool isPrime = true;

		for(int i=2;i<number;i++){
			
			if(number%i == 0){
				isPrime = false;
				break;
			}
		}

		if(isPrime == true){
			Console.WriteLine(number+" is a prime number");
		}
		else{
			Console.WriteLine(number+" is not a prime number");
		}
	}
}
