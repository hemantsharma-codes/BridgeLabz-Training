using System;
class TotalSum{
	static void Main(String[] args){

		double total = 0.0;

		Console.WriteLine("Enter the value :");
		double userValue = double.Parse(Console.ReadLine());

		while(userValue != 0){

			total += userValue;
			Console.WriteLine("Enter the value again :");
			userValue = double.Parse(Console.ReadLine());

		}

		Console.WriteLine("The total sum is "+total);

	}
}
