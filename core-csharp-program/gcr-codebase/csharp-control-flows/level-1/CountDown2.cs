using System;
class CountDown2{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int countDown = int.Parse(Console.ReadLine());

		for(int i=countDown;i>=1;i--){
			Console.WriteLine(""+i);
		}
	}
}
