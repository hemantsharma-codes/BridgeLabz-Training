using System;
class NumberCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		if(number > 0){
			Console.WriteLine("positive");
		}
		else if(number < 0){
			Console.WriteLine("negative");
		}
		else{
			Console.WriteLine("zero");
		}
	}
}
