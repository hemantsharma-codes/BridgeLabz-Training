using System;
class OddEven{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		// checking the number is natural or not
		if(number > 0){

			Console.WriteLine(number+" is a natural number");

			// printing 1 to n odd or even number
			
			for(int i=1;i<=number;i++){

				if(i%2 == 0){
					Console.WriteLine(i+" is an even number");
				}
				else{
					Console.WriteLine(i+" is an odd number");
				}
			}
		}
		else{
			Console.WriteLine(number+" is not a natural number");
		}
	}
}
