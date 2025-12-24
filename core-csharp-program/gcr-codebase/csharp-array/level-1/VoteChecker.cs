using System;
class VoteChecker{
	static void Main(String[] args){

		int[] students = new int[10];

		Console.WriteLine("Enter the age of Students.");
		for(int i=0;i<10;i++){
			students[i] = int.Parse(Console.ReadLine());
		}

		for(int i=0;i<10;i++){

			if(students[i] >= 18){
				Console.WriteLine("The student with the age "+students[i]+" can vote.");
			}
			else{
				Console.Error.WriteLine("The student with the age "+students[i]+" cannot vote.");
			}
		}

	}
}
