using System;
class FrequencyOfDigit{
	static void Main(String[] args){

		// take a number for input
		Console.WriteLine("Enter a number :");
		long number = long.Parse(Console.ReadLine());

		int countOfDigit = 0;
		long temp = number;

		while(temp > 0){
			countOfDigit++;
			temp /= 10;
		}

		// create a array to store the digit of number
		int[] arr = new int[countOfDigit];
		int idx = 0;
		while(number > 0){
			arr[idx] = (int)number%10;
			idx++;
			number /= 10;
		}

		int[] count = new int[10];
		for(int i=0;i<arr.Length;i++){
			count[arr[i]]++;
		}

		for(int i=0;i<10;i++){	
			if(count[i] != 0){
				Console.WriteLine("Frequency of "+i+" is "+count[i]);
			}
		}
	}
}
