using System;
class QuotientAndRemainder{
	static double[] FindQuotientAndRemainder(int number1,int number2){
		
		double quotient = (double)number1/number2;
		double remainder = (double)number1%number2;

		return new double[] {quotient,remainder};
	}
	static void Main(String[] args){

		// take input for 2 numbers
		Console.WriteLine("Please enter 2 numbers :");
		int number1 = int.Parse(Console.ReadLine());
		int number2 = int.Parse(Console.ReadLine());

		// create array of size 2 to store the result
		double[] result = new double[2];

		result = FindQuotientAndRemainder(number1,number2);

		Console.WriteLine("The quotient "+result[0]+", and The remainder "+result[1]+" of number1 "+number1+" and number2 "+number2);
	}
}
