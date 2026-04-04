using System;
class FindMultiple{
	static void Main(String[] args){

		Console.WriteLine("Enter the number below 100 :");
		int number = int.Parse(Console.ReadLine());

		Console.WriteLine("The multiples of "+number+" are : ");
		for(int i=100;i>=1;i--){
			
			if(number%i == 0){
				Console.WriteLine(i+"");
			}
		}
	}
}
