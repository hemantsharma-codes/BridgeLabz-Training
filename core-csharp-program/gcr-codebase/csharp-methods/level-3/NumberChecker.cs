using System;
class NumberChecker{
        // method to count digits in a number
        static int CountDigits(int number){
                int count = 0;
                while(number != 0){
                        count++;
                        number = number / 10;
                }
                return count;
        }

        // method to store digits in an array
        static int[] StoreDigits(int number){
                int size = CountDigits(number);
                int[] digits = new int[size];
                int index = size - 1;

                while(number != 0){
                        digits[index] = number % 10;
                        number = number / 10;
                        index--;
                }
                return digits;
        }

        // method to check duck number
        static bool IsDuckNumber(int[] digits){
                for(int i=0;i<digits.Length;i++){
                        if(digits[i] != 0){
                                return true;
                        }
                }
                return false;
        }

        // method to check armstrong number
        static bool IsArmstrong(int number,int[] digits){
                int sum = 0;
                int power = digits.Length;

                for(int i=0;i<digits.Length;i++){
                        sum = sum + (int)Math.Pow(digits[i],power);
                }

                if(sum == number)
                        return true;
                else
                        return false;
        }

        // method to find largest and second largest digit
        static int[] FindLargestAndSecondLargest(int[] digits){
                int largest = Int32.MinValue;
                int secondLargest = Int32.MinValue;

                for(int i=0;i<digits.Length;i++){
                        if(digits[i] > largest){
                                secondLargest = largest;
                                largest = digits[i];
                        }
                        else if(digits[i] > secondLargest && digits[i] != largest){
                                secondLargest = digits[i];
                        }
                }
                return new int[]{largest,secondLargest};
        }

        // method to find smallest and second smallest digit
        static int[] FindSmallestAndSecondSmallest(int[] digits){
                int smallest = Int32.MaxValue;
                int secondSmallest = Int32.MaxValue;

                for(int i=0;i<digits.Length;i++){
                        if(digits[i] < smallest){
                                secondSmallest = smallest;
                                smallest = digits[i];
                        }
                        else if(digits[i] < secondSmallest && digits[i] != smallest){
                                secondSmallest = digits[i];
                        }
                }
                return new int[]{smallest,secondSmallest};
        }

        static void Main(string[] args){

                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                int digitCount = CountDigits(number);
                int[] digits = StoreDigits(number);

                Console.WriteLine("Count of digits: "+digitCount);

                Console.WriteLine("Digits are:");
                for(int i=0;i<digits.Length;i++){
                        Console.WriteLine(digits[i]);
                }

                if(IsDuckNumber(digits))
                        Console.WriteLine("It is a Duck number");
                else
                        Console.WriteLine("It is not a Duck number");

                if(IsArmstrong(number,digits))
                        Console.WriteLine("It is an Armstrong number");
                else
                        Console.WriteLine("It is not an Armstrong number");

                int[] large = FindLargestAndSecondLargest(digits);
                Console.WriteLine("Largest digit: "+large[0]);
                Console.WriteLine("Second largest digit: "+large[1]);

                int[] small = FindSmallestAndSecondSmallest(digits);
                Console.WriteLine("Smallest digit: "+small[0]);
                Console.WriteLine("Second smallest digit: "+small[1]);
        }
}

