using System;
class DistanceConverter{
	static void Main(String[] args){

		Console.WriteLine("Enter the distance in km : ");
		double km = double.Parse(Console.ReadLine());

		double miles = km/1.6;

		Console.WriteLine("The total miles is "+ miles +"mile for the given "+ km +"km");

	}
}


