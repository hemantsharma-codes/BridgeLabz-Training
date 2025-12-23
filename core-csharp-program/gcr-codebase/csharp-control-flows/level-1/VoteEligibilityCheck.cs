using System;
class VoteEligibilityCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the age of person :");
		int age = int.Parse(Console.ReadLine());

		if(age >= 18){
			Console.WriteLine("The person can vote.");
		}
		else{
			Console.WriteLine("The person cannot vote.");
		}
	}
}
