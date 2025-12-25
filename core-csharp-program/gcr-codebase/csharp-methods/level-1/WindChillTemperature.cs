using System;
class WindChillTemperature{
	static double CalculateWindChill(double temp,double windSpeed){
		double windChill = 35.74+0.6215*temp+(0.4275*temp-35.75)*Math.Pow(windSpeed,0.16);
		return windChill;
	}
	static void Main(String[] args){

		// take the input for temperature and wind speed
		Console.WriteLine("Enter the temperature and wind speed :");
		double temp = double.Parse(Console.ReadLine());
		double windSpeed = double.Parse(Console.ReadLine());

		// method calling
		double windChill = CalculateWindChill(temp,windSpeed);

		Console.WriteLine("The wind chill temperature :"+windChill);
	}
}
