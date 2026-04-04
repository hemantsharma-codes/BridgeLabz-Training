using System;
class ArraySum{
	static void Main(String[] args){

		// creating an array of size 10
		double[] arr = new double[10];

		// taking a varible of name total to store the sum of array elements
		double total = 0.0;

		// taking the index idx to iterate the array
		int idx = 0;

		while(true){

			Console.WriteLine("Enter the number :");
			int number = int.Parse(Console.ReadLine());

			if(number <= 0 || idx == 10){
				break;
			}
			arr[idx] = number;
			idx++;
		}

		// adding the all elements of array 

		for(int i=0;i<idx;i++){
			total += arr[i];
		}

		Console.WriteLine("The total sum is : "+total);
	}
}

		
