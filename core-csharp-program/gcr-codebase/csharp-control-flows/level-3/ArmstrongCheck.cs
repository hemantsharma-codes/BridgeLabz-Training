using System;
class ArmstrongCheck{
	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());


		// finding the legnth of the number
		int temp = number;
		int len = 0;
		while(temp > 0){
			temp = temp/10;
			len++;
		}

		// now calculating sum

		temp = number;
		int sum = 0;
		while(temp > 0){
			int digit = temp%10;
			sum += (int)Math.Pow(digit,len);
			temp = temp/10;
		}
		
		// checking sum is equal to the real number

		if(sum == number){
			Console.WriteLine(number+" is an Armstrong number.");
		}
		else{
			Console.WriteLine(number+" is not an Armstrong number.");
		}
	}
}
