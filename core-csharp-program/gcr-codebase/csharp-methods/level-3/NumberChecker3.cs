using System;
class NumberChecker{
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

        // method to reverse digits array
        static int[] ReverseDigits(int[] digits){
                int[] reversed = new int[digits.Length];
                int index = 0;

                for(int i=digits.Length-1;i>=0;i--){
                        reversed[index] = digits[i];
                        index++;
                }
                return reversed;
        }

        // method to compare two arrays
        static bool CompareArrays(int[] arr1,int[] arr2){
                if(arr1.Length != arr2.Length)
                        return false;

                for(int i=0;i<arr1.Length;i++){
                        if(arr1[i] != arr2[i])
                                return false;
                }
                return true;
        }

        // method to check palindrome number
        static bool IsPalindrome(int[] digits){
                int[] reversed = ReverseDigits(digits);
                return CompareArrays(digits,reversed);
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

        static void Main(string[] args){

                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                int[] digits = StoreDigits(number);

                Console.WriteLine("Digits are:");
                for(int i=0;i<digits.Length;i++){
                        Console.WriteLine(digits[i]);
                }

                if(IsPalindrome(digits)){
                        Console.WriteLine("It is a Palindrome number");
		}
                else{
                        Console.WriteLine("It is not a Palindrome number");
		}

                if(IsDuckNumber(digits)){
                        Console.WriteLine("It is a Duck number");
		}
                else{
                        Console.WriteLine("It is not a Duck number");
		}
        }
}

