using System;
class HarshadNumberCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());


		int sum = 0;
		int temp = number;

		while(temp > 0){

			sum += temp%10;
			temp = temp/10;

		}

		if(number%sum == 0){

			Console.WriteLine(number+" is a Harshad number.");

		}
		else{
			Console.WriteLine(number+" is not a Harshad number.");
		}
	}
}
