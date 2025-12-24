using System;
class BmiCalculator2{
	static void Main(String[] args){

		// take input for a number of persons
		Console.WriteLine("Please enter the number of persons :");
		int number = int.Parse(Console.ReadLine());

		// Create a multidimensional array to store weight, height and bmi
		double[,] personData = new double[number,3];

		// create a 1D array to store weight status
		string[] weightStatus = new string[number];

		// take the input for weight and height

		for(int i=0;i<number;i++){

			Console.WriteLine("Enter the weight and height of the "+(i+1)+" person :");
			double weight = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			// alert for negative weight and height
			if(weight <= 0 || height <= 0){
				Console.WriteLine("Error: please enter the positive weight and height.");
				i--;
			}
			else{
				personData[i,0] = weight;
				personData[i,1] = height;
			}
		}

		// calculate bmi of each person
		for(int i=0;i<number;i++){
			double bmi = personData[i,0]/(personData[i,1]*personData[i,1]);
			personData[i,2] = bmi;

			if(bmi <= 18.4){
				weightStatus[i] = "Underweight";
			}
			else if(bmi >= 18.5 && bmi <= 24.9){
				weightStatus[i] = "Normal";
			}
			else if(bmi >= 25.0 && bmi <= 39.9){
				weightStatus[i] = "Overwight";
			}
			else{
				weightStatus[i] = "Obese";
			}
		}

		
		// display the result
		for(int i=0;i<number;i++){
			Console.WriteLine("Weight = "+personData[i,0]+", height = "+personData[i,1]+", bmi = "+personData[i,2]+", weight status = "+weightStatus[i]);
		}
	}
}


			
