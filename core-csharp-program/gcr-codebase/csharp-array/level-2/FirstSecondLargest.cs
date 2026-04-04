using System;
class FirstSecondLargest{
	static void Main(string[] args){

		// take a number input
		Console.WriteLine("Enter the number :");
		long number = long.Parse(Console.ReadLine());

		// create a variable of name maxDigit size is 10
		int maxDigit = 10;
		int[] arr = new int[maxDigit];

		// set array's index to 0
		int idx = 0;

		// handle negative number
		if(number < 0){
			number = -number;
		}

		// store number's digit into an array
		while(number > 0){

			if(idx == maxDigit){
				break;
			}
			arr[idx] = (int)number%10;
			idx++;
			number /= 10;
		}

		// checking array must have atleast 2 digit
		if(1 <= idx){
			Console.WriteLine("Number must have atleast 2 digit.");
			return;
		}


		// take two variable largest and secondLargest
		int largest = 0;
		int secondLargest = 0;

		if(arr[0] > arr[1]){
			largest = arr[0];
			secondLargest = arr[1];
		}else{
			largest = arr[1];
			secondLargest = arr[0];
		}

		for(int i=2;i<idx;i++){
			if(largest < arr[i]){
				secondLargest = largest;
				largest = arr[i];
			}
			else if(largest != arr[i] && secondLargest < arr[i]){
				secondLargest = arr[i];
			}
		}

		Console.WriteLine("The largest digit of the number is : "+largest);
		Console.WriteLine("The second largest digit of the number is : "+secondLargest);
	}
}


