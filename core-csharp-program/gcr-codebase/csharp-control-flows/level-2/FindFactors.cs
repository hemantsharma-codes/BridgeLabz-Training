using System;
class FindFactors{
	static void Main(String[] args){
		
		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("The factors of "+number+" are : ");
		for(int i=1;i<number;i++){

			if(number%i == 0){
				Console.WriteLine(i+"");
			}
		}
	}
}
