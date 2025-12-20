using System;
class PoundsToKgConverter{
	static void Main(String[] args){

		Console.WriteLine("Enter the value of weight in pounds :");
		double weightPounds = double.Parse(Console.ReadLine());

		double weightKg = weightPounds/2.2;

		Console.WriteLine("The weight of the person in pounds is "+weightPounds+" and kg is "+weightKg);

	}
}

