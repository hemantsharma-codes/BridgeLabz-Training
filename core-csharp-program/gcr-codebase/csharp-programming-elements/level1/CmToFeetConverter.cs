using System;
class CmToFeetConverter{
	static void Main(String[] args){

		Console.WriteLine("Enter your height in centimeters :");
		double heightCm = double.Parse(Console.ReadLine());

		double totalInches = heightCm / 2.54;
		int feet = (int)(totalInches / 12);
		double inches = totalInches % 12;

		Console.WriteLine("Your height in cm is "+heightCm+" while in feet is "+feet+" and inches is "+inches);
	}
}
