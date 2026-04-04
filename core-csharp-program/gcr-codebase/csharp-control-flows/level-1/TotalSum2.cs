using System;
class TotalSum2{
	static void Main(String[] args){

		double total = 0.0;

		Console.WriteLine("Enter the value :");
		double userValue = double.Parse(Console.ReadLine());

		while(true){
			if(userValue <= 0){
				break;
			}
			total += userValue;

			Console.WriteLine("Enter the value again :");
			userValue = double.Parse(Console.ReadLine());

		}

		Console.WriteLine("The total value is :"+total);
	}
}
