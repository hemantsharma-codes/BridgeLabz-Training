using System;
class NumberChecker2{
        // method to count digits
        static int CountDigits(int number){
                int count = 0;
                while(number != 0){
                        count++;
                        number = number / 10;
                }
                return count;
        }

        // method to store digits in array
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

        // method to find sum of digits
        static int SumOfDigits(int[] digits){
                int sum = 0;
                for(int i=0;i<digits.Length;i++){
                        sum = sum + digits[i];
                }
                return sum;
        }

        // method to find sum of squares of digits
        static int SumOfSquares(int[] digits){
                int sum = 0;
                for(int i=0;i<digits.Length;i++){
                        sum = sum + (int)Math.Pow(digits[i],2);
                }
                return sum;
        }

        // method to check Harshad number
        static bool IsHarshadNumber(int number,int[] digits){
                int sum = SumOfDigits(digits);
                if(sum != 0 && number % sum == 0)
                        return true;
                else
                        return false;
        }

        // method to find frequency of each digit
        static int[,] FindDigitFrequency(int[] digits){
                int[,] frequency = new int[10,2];

                for(int i=0;i<10;i++){
                        frequency[i,0] = i;
                        frequency[i,1] = 0;
                }

                for(int i=0;i<digits.Length;i++){
                        frequency[digits[i],1]++;
                }

                return frequency;
        }

        static void Main(string[] args){

                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                int[] digits = StoreDigits(number);

                Console.WriteLine("Digits are:");
                for(int i=0;i<digits.Length;i++){
                        Console.WriteLine(digits[i]);
                }

                int digitSum = SumOfDigits(digits);
                Console.WriteLine("Sum of digits: "+digitSum);

                int squareSum = SumOfSquares(digits);
                Console.WriteLine("Sum of squares of digits: "+squareSum);

                if(IsHarshadNumber(number,digits))
                        Console.WriteLine("It is a Harshad number");
                else
                        Console.WriteLine("It is not a Harshad number");

                int[,] freq = FindDigitFrequency(digits);

                Console.WriteLine("Digit Frequency:");
                for(int i=0;i<10;i++){
                        if(freq[i,1] > 0){
                                Console.WriteLine(freq[i,0]+" -> "+freq[i,1]);
                        }
                }
        }
}

