using System;
class SimpleInterest{
	static double CalculateSimpleInterest(double principal,double rate,double time){

		double si = (principal*rate*time)/100;
		return si;
	}
	static void Main(string[] args){

		// take input for principal, rate, and time
		Console.WriteLine("Enter the principal :");
		double principal = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the rate of interest :");
		double rate = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the time :");
		double time = double.Parse(Console.ReadLine());


		// calling method
		double si = CalculateSimpleInterest(principal,rate,time);

		Console.WriteLine("The SI is "+si+" for Principal "+principal+", Rate of Interest "+rate+", and Time "+time);
	}
}
