using System;
class NumberChecker4{
        // method to check prime number
        static bool IsPrime(int number){
                if(number <= 1){
                        return false;
                }

                for(int i=2;i<number;i++){
                        if(number % i == 0){
                                return false;
                        }
                }
                return true;
        }

        // method to check neon number
        static bool IsNeon(int number){
                int square = number * number;
                int sum = 0;

                while(square != 0){
                        sum += square % 10;
                        square = square / 10;
                }
                return sum == number;
        }

        // method to check spy number
        static bool IsSpy(int number){
                int sum = 0;
                int product = 1;

                while(number != 0){
                        int digit = number % 10;
                        sum += digit;
                        product *= digit;
                        number = number / 10;
                }
                return sum == product;
        }

        // method to check automorphic number
        static bool IsAutomorphic(int number){
                int square = number * number;
                int temp = number;

                while(temp != 0){
                        if(temp % 10 != square % 10){
                                return false;
                        }
                        temp = temp / 10;
                        square = square / 10;
                }
                return true;
        }

        // method to check buzz number
        static bool IsBuzz(int number){
                if(number % 7 == 0 || number % 10 == 7){
                        return true;
                }
                return false;
        }

        static void Main(string[] args){

                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                if(IsPrime(number)){
                        Console.WriteLine("It is a Prime number");
                }else{
                        Console.WriteLine("It is not a Prime number");
                }

                if(IsNeon(number)){
                        Console.WriteLine("It is a Neon number");
                }else{
                        Console.WriteLine("It is not a Neon number");
                }

                if(IsSpy(number)){
                        Console.WriteLine("It is a Spy number");
                }else{
                        Console.WriteLine("It is not a Spy number");
                }

                if(IsAutomorphic(number)){
                        Console.WriteLine("It is an Automorphic number");
                }else{
                        Console.WriteLine("It is not an Automorphic number");
                }

                if(IsBuzz(number)){
                        Console.WriteLine("It is a Buzz number");
                }else{
                        Console.WriteLine("It is not a Buzz number");
                }
        }
}

