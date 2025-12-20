using System;
class TravelComputation{
	static void Main(String[] args){
		
		Console.WriteLine("Enter the name of the person :");
		String name = Console.ReadLine();

		Console.WriteLine("Enter the city name from where you are starting :");
		String fromCity = Console.ReadLine();

		Console.WriteLine("Enter the city from where from you will go through :");
		String viaCity = Console.ReadLine();

		Console.WriteLine("Enter the city where you are going :");
		String toCity = Console.ReadLine();



		// distance
		Console.WriteLine("Enter the distance fromCity to viaCity :");
		int fromToVia = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the distance viaCity to toCity :");
		int viaToFinalCity = int.Parse(Console.ReadLine());

		// time

		Console.WriteLine("Enter the time you will take fromCity to viaCity :");
		int timeFromToVia = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the time you will take viaCity to toCity :");
		int timeViaToFinalCity = int.Parse(Console.ReadLine());
		

		int totalDistance = fromToVia+viaToFinalCity;

		int totalTime = timeFromToVia + timeViaToFinalCity;

		Console.WriteLine("The time is taken "+totalTime+"min to reach final city and the total distance is "+totalDistance+" km");
	}
}
