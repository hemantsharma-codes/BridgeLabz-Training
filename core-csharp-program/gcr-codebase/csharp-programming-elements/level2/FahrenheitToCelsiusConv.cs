using System;
class FahrenheitToCelsiusConv{
	static void Main(String[] args){

		Console.WriteLine("Enter the value of temperature in fahrenheit :");
		double fahrenheit = double.Parse(Console.ReadLine());

		double celsiusResult = (fahrenheit - 32)*5/9;

		Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsiusResult+" Celsius");
	}
}
