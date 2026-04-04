using System;
class FactorialCalculator2{
        static void Main(String[] args){

                Console.WriteLine("Enter the number :");
                int number = int.Parse(Console.ReadLine());

                // checking the number is positive or not

                if(number > 0){

                        int fact = 1;
                        // calculating factorial

                        for(int i=number;i>0;i--){
				fact *= i;
			}

                        Console.WriteLine("The number is positive and the factorial is "+fact);
                }
                else{
                        Console.WriteLine("The number is negative.");
                }
        }
}

