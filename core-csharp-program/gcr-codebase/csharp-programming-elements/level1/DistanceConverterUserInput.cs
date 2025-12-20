using System;
class DistanceConverterUserInput{
	static void Main(String[] args){

		Console.WriteLine("Enter the distance in feet :");
		double distanceInFeet = double.Parse(Console.ReadLine());

		double distanceInYards = distanceInFeet/3;

		double distanceInMiles = distanceInYards/1760;

		Console.WriteLine("The distance in feet is "+distanceInFeet+", and distance in yards "+distanceInYards+", distance in miles "+distanceInMiles);
	}
}
