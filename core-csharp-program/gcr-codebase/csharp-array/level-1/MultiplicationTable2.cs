using System;
class MultiplicationTable2{
	static void Main(String[] args){

		Console.WriteLine("Enter the number int between 6 to 9 :");
		int number = int.Parse(Console.ReadLine());

		int[] result = new int[10];

		for(int i=0;i<10;i++){
			result[i] = (i+1)*number;
		}

		
		for(int i=0;i<10;i++){
			Console.WriteLine(number+" * "+(i+1)+" = "+ result[i]);
		}

	}
}
