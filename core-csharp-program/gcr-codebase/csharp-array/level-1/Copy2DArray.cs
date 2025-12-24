using System;
class Copy2DArray{
	static void Main(String[] args){

		// take input of row and col
		Console.WriteLine("Enter the row size :");
		int row = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the size of column :");
		int col = int.Parse(Console.ReadLine());

		// Create 2D array

		int[,] matrix = new int[row,col];

		Console.WriteLine("Enter the elements of 2D array :");
		for(int i=0;i<row;i++){
			for(int j=0;j<col;j++){
				matrix[i,j] = int.Parse(Console.ReadLine());
			}
		}

		// create 1D copy the item of 2D array
		int[] array = new int[row*col];

		// copy the item using for loop
		int idx = 0;

		for(int i=0;i<row;i++){
			for(int j=0;j<col;j++){
				array[idx++] = matrix[i,j];
			}
		}

		// Display the items of 1D array
		Console.WriteLine("Elements of 1D array :");
		for(int i=0;i<array.Length;i++){
			Console.Write(array[i]+" ");
		}
	}
}
