using System;
class MaxNumberHandShake{
	static void Main(String[] args){

		Console.WriteLine("Enter the number of students : ");
		int students = int.Parse(Console.ReadLine());

		double maxNoHandShake = (double) (students*(students-1))/2;

		Console.WriteLine("The number of possible handshakes : "+maxNoHandShake);
	}
}
