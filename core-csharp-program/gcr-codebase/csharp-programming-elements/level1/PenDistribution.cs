using System;
class PenDistribution{
	static void Main(String[] args){

		int numOfPen = 14;
		int numOfStudent = 3;

		Console.WriteLine("The Pen per Student is "+(numOfPen/numOfStudent)+" and the remaining pen not distributed is "+(numOfPen%numOfStudent));
	}
}
