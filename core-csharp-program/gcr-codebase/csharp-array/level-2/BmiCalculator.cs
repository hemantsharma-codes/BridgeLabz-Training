using System;
class BmiCalculator{
	static void Main(String[] args){

		// take input for a number of persons
		Console.WriteLine("Please enter the number of persons :");
		int number = int.Parse(Console.ReadLine());

		// create arrays to store weight, height, BMI and weight status of persons

		double[] weight = new double[number];
		double[] height = new double[number];
		double[] bmi = new double[number];
		double[] weightStatus = new double[number];

		// take input for the weight and height for the persons

		for(int i=0;i<number;i++){
			
			Console.WriteLine("Enter the weight of "+(i+1)+" person");
			weight[i] = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter the height of "+(i+1)+" person");
			height[i] = 0.01*double.Parse(Console.ReadLine());

		}

		// Calculate the bmi of all persons
		for(int i=0;i<number;i++){
			bmi[i] = weight[i]/(height[i]*height[i]);
		}

		// display the height, weight, BMI, and weight status
		for(int i=0;i<number;i++){
			if(bmi[i] <= 18.4){
				Console.WriteLine("BMI : "+bmi[i]+", Height : "+height[i]+", Weight[i] : "+weight[i]+", Weight Status : Underweight");
			}
			else if(bmi[i] >= 18.5 && bmi[i] <= 24.9){
			        Console.WriteLine("BMI : "+bmi[i]+", Height : "+height[i]+", Weight : "+weight[i]+", Weight Status : Normal");
			}
			else if(bmi[i] >= 25.0 && bmi[i] <= 39.9){
				Console.WriteLine("BMI : "+bmi[i]+", Height : "+height[i]+", Weight[i] : "+weight[i]+", Weight Status : Overweight");
			}
			else{
				Console.WriteLine("BMI : "+bmi[i]+", Height : "+height[i]+", Weight[i] : "+weight[i]+", Weight Status : Obese");
			}
		}
	}
}

