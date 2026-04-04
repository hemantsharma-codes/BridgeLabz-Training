using System;
class TestScoreAnalyzer{
	private static int[] scores;
	private static int numberOfStudents;

	private static void Main(string[] args){
		
		StartApp();
	}
	private static void StartApp(){

		Console.WriteLine("/===================Student Test Score Analyzer========================/");

		// taking user input through a method call
		TakeUserInput();

		// Displaying menu
		DisplayMenu();
		Console.WriteLine("Please enter the right button : ");
		int button = int.Parse(Console.ReadLine());

		switch(button){
			case 1:
				Console.WriteLine("The avg marks of students test : "+CalculateAverageScore());
				break;
			case 2:
				FindHighestAndLowestScore();
				break;
			case 3:
				DisplayScoreAboveAverage();
				break;
			default:
				Console.WriteLine("Please enter the valid number : ");
				break;
		}

	}
	private static void TakeUserInput(){

		Console.WriteLine("Enter the number of students :");
		numberOfStudents = int.Parse(Console.ReadLine());

		scores = new int[numberOfStudents];

		// taking user input for names 
		for(int i=0;i<scores.Length;i++){
			Console.WriteLine("Enter the marks of student : "+(i+1));
			scores[i] = int.Parse(Console.ReadLine());
		}
	}
	private static void DisplayMenu(){

		Console.WriteLine("Press 1 for : Calculate and display the average score.");
		Console.WriteLine("Press 2 for : Find and display the highest and lowest score.");
		Console.WriteLine("Press 3 for : Identify and display the scores above the average.");
	
        }
	private static float CalculateAverageScore(){
		int sum = 0;
	
		for(int i=0;i<scores.Length;i++){
			sum += scores[i];
		}
		float averageScore = (float)sum/scores.Length;
		return averageScore;
	}
	private static void FindHighestAndLowestScore(){
		
		int highestScore = int.MinValue;
		int lowestScore = int.MaxValue;

		for(int i=0;i<scores.Length;i++){
			highestScore = Math.Max(highestScore,scores[i]);
			lowestScore = Math.Min(lowestScore,scores[i]);
		}

		Console.WriteLine("The highest score is : "+highestScore+" and the lowest score is : "+lowestScore);
	}
	private static void DisplayScoreAboveAverage(){
		float avg = CalculateAverageScore();

		Console.WriteLine("\nThe scores above average are : \n");
		for(int i=0;i<scores.Length;i++){
			if(avg < scores[i]){
				Console.WriteLine(scores[i]);
			}
		}
	}
}

