using System;
class PercentageGrade2{
	static void Main(String[] args){

		// take the input for number of students
		Console.WriteLine("Please enter the number of students :");
		int students = int.Parse(Console.ReadLine());

		// create a 2D array to store the marks
		int[,] marks = new int[students,3];

		for(int i=0;i<students;i++){

			Console.WriteLine("Enter the marks of physics, chemistry, and math of student "+(i+1));
			int physics = int.Parse(Console.ReadLine());
			int chemistry = int.Parse(Console.ReadLine());
			int math = int.Parse(Console.ReadLine());

			if(physics <= 0 || chemistry <= 0 || math <= 0){
				Console.WriteLine("Please enter the positve marks.");
				i--;
			}
			else{
				marks[i,0] = physics;
				marks[i,1] = chemistry;
				marks[i,2] = math;
			}
		}

		// calculate percentage
		double[] percentage = new double[students];
		for(int i=0;i<students;i++){
			percentage[i] = (marks[i,0]+marks[i,1]+marks[i,2])/3.0;
		}

		// display the result

		for(int i=0;i<students;i++){
			
			if(percentage[i] >= 80.0){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", Grade : A");
			}
			else if(percentage[i] >= 70.0 && percentage[i] <= 79.9){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", Grade : B");
			}
			else if(percentage[i] >= 60.0 && percentage[i] <= 69.9){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", Grade : C");
			}
			else if(percentage[i] >= 50.0 && percentage[i] <= 59.9){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", Grade : D");
			}
			else if(percentage[i] >= 40.0 && percentage[i] <= 49.9){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", Grade : E");
			}
			else{
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", Grade : R");
			}
		}
	}
}

