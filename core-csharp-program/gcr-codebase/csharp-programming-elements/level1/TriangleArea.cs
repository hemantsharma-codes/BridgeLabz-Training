using System;
class TriangleArea{
	static void Main(String[] args){

		Console.WriteLine("Enter base of triangle in inches :");
		double baseInch = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter height of trianlge in inches :");
		double heightInch = double.Parse(Console.ReadLine());

		double areaSqInch = 0.5 * baseInch * heightInch;
		double areaSqCm = areaSqInch * 6.4516;

		Console.WriteLine("Area of traingle is "+areaSqInch+" sqaure inches and "+areaSqCm+" sqaure centimeters");

	}
}
