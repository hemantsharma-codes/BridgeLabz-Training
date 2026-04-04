using System;
class Bmi{
	static void Main(String[] args){

		Console.WriteLine("Enter the weight of person in kg :");
		double weight = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the height of person in cm :");
		double height = double.Parse(Console.ReadLine());

		// converting height cm to m
		height = height/100;

		double bmi = weight/(height*height);

		if(bmi <= 18.4){

			Console.WriteLine("The person is Underweight.");

		}
		else if(bmi >= 18.5 && bmi <= 24.9){

			Console.WriteLine("The person has Noraml weight.");

		}
		else if(bmi >= 25.0 && bmi <= 39.9){

			Console.WriteLine("The Person is Overweight.");

		}
		else if(bmi <= 40.0){
			
			Console.WriteLine("The Person has Obese.");

		}
	}
}

