using System;
class KmToMiles{
	static void Main(String[] args){

		float distanceInKm = 10.8f;

		float distanceInMiles = distanceInKm*0.621371f;

		Console.WriteLine("The distance "+distanceInKm+"km in miles is "+distanceInMiles);
	}
}
