using System;
class CountDown{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int countDown = int.Parse(Console.ReadLine());

		while(countDown >= 1){
			Console.WriteLine(""+countDown);
			countDown--;

		}
	}
}
