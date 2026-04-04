using System;
public class StudentVoteChecker{
	public static bool CanStudentVote(int age){
		// validate negative age
                if (age < 0){
			return false;
		}
		if (age >= 18){
			return true;
		}
		return false;
	}

	static void Main(string[] args){
		// array to store age of 10 students
		int[] studentAges = new int[10];

		for (int i = 0; i < studentAges.Length; i++){
			Console.WriteLine("Enter age of student "+(i+1)+" :");
                        studentAges[i] = int.Parse(Console.ReadLine());

                       // call method
                       bool isValid = CanStudentVote(studentAges[i]);

                       if (isValid){
			       Console.WriteLine("Student "+(i+1)+" is eligible to vote.");
		       }
		       else{
			       Console.WriteLine("Student "+(i+1)+" is NOT eligible to vote.");
		       }
		       Console.WriteLine();
		}
	}
}

