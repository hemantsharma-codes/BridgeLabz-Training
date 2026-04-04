using System;
class HandshakesCalculator{
	static int CalculateMaxNumberOfHandshakes(int students){
		// calculate max number of handshakes
		int total = (students*(students-1))/2;
		return total;
	}
	static void Main(String[] args){

		// take input for number of students
		Console.WriteLine("Enter the number of students :");
		int students = int.Parse(Console.ReadLine());

		// calling methods
		int totalHandshakes = CalculateMaxNumberOfHandshakes(students);

		// display the result
		Console.WriteLine("The maximum number of handshakes can be : "+totalHandshakes);
	}
}
