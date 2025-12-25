using System;
class TriangularPark{
	static double CalculateRounds(double side1,double side2,double side3){

		double distanceToCover = 5000; // 5km = 5000meters
		double perimeter = (side1+side2+side3);

		double rounds = distanceToCover/perimeter;
		return rounds;
	}
	static void Main(String[] args){

		// take user input for 3 sides of triangular
		Console.WriteLine("Please enter 3 sides of triangular park :");
		double side1 = double.Parse(Console.ReadLine());
		double side2 = double.Parse(Console.ReadLine());
		double side3 = double.Parse(Console.ReadLine());

		// call methods
		double totalRounds = CalculateRounds(side1,side2,side3);

		// display result
		Console.WriteLine("The number of ronuds are "+totalRounds+" athelete needs to complete 5km distance.");
	}
}


