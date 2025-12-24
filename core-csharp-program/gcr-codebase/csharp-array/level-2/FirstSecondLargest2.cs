using System;
class FirstSecondLargest{
	static void Main(string[] args){
		// take a input  of name number
		Console.WriteLine("Enter the number :");
		long number = long.Parse(Console.ReadLine());

		// handle negative number
		if (number < 0){
			number = -number;
		}
		int maxDigit = 10;
                int[] arr = new int[maxDigit];
                int idx = 0;

                // store digits of number into array
                while (number>0){
			if(idx == maxDigit){
				maxDigit = maxDigit*2;
				int[] temp = new int[maxDigit];

				for(int i=0;i<arr.Length;i++){
					temp[i] = arr[i];
				}
				arr = temp;
			}
			arr[idx++] = (int)number%10;
			number /= 10;
		}

               // check for number has at least two digits
               if(idx<2){
		       Console.WriteLine("Number must have at least two digits.");
                       return;
               }

               // initialize using first two digits
               int largest = 0;
	       int secondLargest = 0;

	       if(arr[0] > arr[1]){
		       largest = arr[0];
                       secondLargest = arr[1];
               }
	       else{
		       largest = arr[1];
		       secondLargest = arr[0];
               }

	       // find largest and second largest
               for (int i = 2; i < idx; i++){
		       if (arr[i] > largest){
			       secondLargest = largest;
                               largest = arr[i];
		       }
		       else if (arr[i] < largest && arr[i] > secondLargest){
			       secondLargest = arr[i];
		       }
	       }
	       Console.WriteLine("The largest digit is : " + largest);
	       Console.WriteLine("The second largest digit is : " + secondLargest);
    }
}

