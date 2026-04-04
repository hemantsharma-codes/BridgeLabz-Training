using System;
class ChocolatesDistribution{
	static int[] FindRemainderAndQuotient(int students, int chocolates){
		int remainder = chocolates%students;
		int quotient = chocolates/students;

		return new int[] {remainder,quotient};
	}

	static void Main(String[] args){

		// take inputs for number of chocolates and numbre of students
		Console.WriteLine("Enter the number of students and chocolates :");
		int numberOfStudents = int.Parse(Console.ReadLine());
		int numberOfChocolates = int.Parse(Console.ReadLine());

		// method callings
		int[] result = new int[2];
		result = FindRemainderAndQuotient(numberOfStudents,numberOfChocolates);

		Console.WriteLine("The number of chocolates each child gets "+result[1]+" and the number of remaining chocolates "+result[0]);
	}
}
