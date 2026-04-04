using System;
class GradeCalculator{
	static void Main(String[] args){

		Console.WriteLine("Enter the marks of physics, chemistry and maths :");
		int physicsMarks = int.Parse(Console.ReadLine());
		int chemistryMarks = int.Parse(Console.ReadLine());
		int mathMarks = int.Parse(Console.ReadLine());

		double avgMarks = (physicsMarks+chemistryMarks+mathMarks)/3.0;

		if(avgMarks >= 80){
			Console.WriteLine("Grade : A and percentage : "+avgMarks);
		}
		else if(avgMarks >= 70 && avgMarks <= 79){
			Console.WriteLine("Grade : B and percentage : "+avgMarks);
		}
		else if(avgMarks >= 60 && avgMarks <= 69){
			Console.WriteLine("Grade : C and percentage : "+avgMarks);
		}
		else if(avgMarks >= 50 && avgMarks <= 59){
			Console.WriteLine("Grade : D and percentage : "+avgMarks);
		}
		else if(avgMarks >= 40 && avgMarks <= 49){
			Console.WriteLine("Grade : E and Percentage : "+avgMarks);
		}
		else{
			Console.WriteLine("Grade : R and perecentage : "+avgMarks);
		}
	}
}
