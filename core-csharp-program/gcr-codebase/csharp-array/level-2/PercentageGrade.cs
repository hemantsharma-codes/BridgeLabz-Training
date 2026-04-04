using System;
class PercentageGrade{
	static void Main(String[] args){

		// take input for the number of students
		Console.WriteLine("Enter the number of students :");
		int students = int.Parse(Console.ReadLine());

		// create arrays to store marks of subject
		int[] physicsMarks = new int[students];
		int[] chemistryMarks = new int[students];
		int[] mathMarks = new int[students];

		for(int i=0;i<students;i++){

			Console.WriteLine("Enter the marks of physics, chemistry and math of student "+(i+1));
			int physics = int.Parse(Console.ReadLine());
			int chemistry = int.Parse(Console.ReadLine());
			int math = int.Parse(Console.ReadLine());

			if(physics <= 0 || chemistry <= 0 || math <= 0){
				Console.WriteLine("Please enter poistive marks.");
				i--;
			}
			else{
				physicsMarks[i] = physics;
				chemistryMarks[i] = chemistry;
				mathMarks[i] = math;
			}
		}


		// calculate percentage
		double[] percentage = new double[students];
		for(int i=0;i<students;i++){
			percentage[i] = (physicsMarks[i]+chemistryMarks[i]+mathMarks[i])/3.0;
		}

		// Display the output

		for(int i=0;i<students;i++){
			
			if(percentage[i] >= 80.0){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", and Grade : A");
			}
			else if(percentage[i] >= 70.0 && percentage[i] <= 79.0){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", and Grade : B");
			}
			else if(percentage[i] >= 60.0 && percentage[i] <= 69.0){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", and Grade : C");
			}
			else if(percentage[i] >= 50.0 && percentage[i] <= 59.0){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", and Grade : D");
			}
			else if(percentage[i] >= 40.0 && percentage[i] <= 49.0){
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", and Grade : E");
			}
			else{
				Console.WriteLine("Student "+(i+1)+" Percentage : "+percentage[i]+", and Grade : R");
			}
		}
	}
}






