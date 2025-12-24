using System;
class Meanheight{
	static void Main(String[] args){

		// creating an array of name height
		double[] height = new double[11];

		Console.WriteLine("Enter the elements of an array :");
		for(int i=0;i<11;i++){
			height[i] = double.Parse(Console.ReadLine());
		}

		// adding the all elements of array into varible name's sum

		double sum = 0.0;
		for(int i=0;i<height.Length;i++){
			sum += height[i];
		}

		double meanHeight = sum/11.0;
		Console.WriteLine("The mean Height of the football team : "+meanHeight);
	}
}
