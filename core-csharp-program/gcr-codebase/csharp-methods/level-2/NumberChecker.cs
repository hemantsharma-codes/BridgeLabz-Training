using System;
class NumberChecker{
	static bool IsPositive(int number){
		if(number >= 0){
			return true;
		}
                return false;
	}

	static bool IsEven(int number){
		if(number%2 == 0){
			return true;
		}
		return false;
	}

	static int Compare(int num1,int num2){
		if(num1>num2){
			return 1;
		}
                else if(num1 == num2){
			return 0;
		}
		return -1;
	}

	static void Main(string[] args){
		int[] numbers = new int[5];

		// take input
                for(int i=0;i<numbers.Length;i++){
			Console.WriteLine("Enter number "+(i+1)+" :");
			numbers[i] = int.Parse(Console.ReadLine());
		}

                Console.WriteLine();

		// check positive/negative and even/odd
		for(int i=0;i<numbers.Length;i++){
			if(IsPositive(numbers[i])){
				if(IsEven(numbers[i])){
					Console.WriteLine(numbers[i]+" is Positive and Even");
				}
				else{
					Console.WriteLine(numbers[i]+" is Positive and Odd");
				}
			}
			else{
				Console.WriteLine(numbers[i]+" is Negative");
			}
		}
		Console.WriteLine();

		// compare first and last elements
                int result = Compare(numbers[0],numbers[numbers.Length-1]);

                if(result == 1){
			Console.WriteLine("First element is Greater than Last element");
                }
		else if(result == 0){
			Console.WriteLine("First element is Equal to Last element");
		}else{
			Console.WriteLine("First element is Less than Last element");
		}
	}
}

