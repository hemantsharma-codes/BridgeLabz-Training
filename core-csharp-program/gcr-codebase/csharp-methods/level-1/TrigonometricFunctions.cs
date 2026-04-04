using System;
class TrigonometricFunctions{
	static double[] CalculateTrigonometricFunctions(double angle){

		// convert degree to radians
		double radians = (angle * Math.PI)/180;

		// calculate angles
		double sine = Math.Sin(radians);
		double cosine = Math.Cos(radians);
		double tangent = Math.Tan(radians);

		// store results in array and return
		return new double[] {sine,cosine,tangent};
	}
	static void Main(String[] args){
		
		// take input angles in degrees
		Console.WriteLine("Enter the angle in degrees :");
		double angle = double.Parse(Console.ReadLine());

		// call method

		double[] result = CalculateTrigonometricFunctions(angle);

		Console.WriteLine("Sine value = "+result[0]+", Consine value = "+result[1]+", and Tangent value = "+result[2]);
	}
}
