using System;
class SiCalculator{
	static void Main(String[] args){

		Console.WriteLine("Enter the value of principal :");
		double principal = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the valub of rate of interest :");
		double rate = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the value of time :");
		double time = double.Parse(Console.ReadLine());

		double si = (principal*rate*time)/100;

		Console.WriteLine("The Simple Interest is "+si+" for principal "+principal+", Rate of interest"+rate+" and Time "+time);

	}
}
