using System;
class NumberChecker{
        // method to find factors of a number
        static int[] FindFactors(int number){
                int count = 0;

                // first loop to count factors
                for(int i=1;i<=number;i++){
                        if(number % i == 0){
                                count++;
                        }
                }

                int[] factors = new int[count];
                int index = 0;

                // second loop to store factors
                for(int i=1;i<=number;i++){
                        if(number % i == 0){
                                factors[index] = i;
                                index++;
                        }
                }
                return factors;
        }

        // method to find greatest factor
        static int FindGreatestFactor(int[] factors){
                int max = factors[0];

                for(int i=1;i<factors.Length;i++){
                        if(factors[i] > max){
                                max = factors[i];
                        }
                }
                return max;
        }

        // method to find sum of factors
        static int FindSumOfFactors(int[] factors){
                int sum = 0;

                for(int i=0;i<factors.Length;i++){
                        sum += factors[i];
                }
                return sum;
        }

        // method to find product of factors
        static long FindProductOfFactors(int[] factors){
                long product = 1;

                for(int i=0;i<factors.Length;i++){
                        product *= factors[i];
                }
                return product;
        }

        // method to find product of cube of factors
        static double FindProductOfCubeOfFactors(int[] factors){
                double product = 1;

                for(int i=0;i<factors.Length;i++){
                        product *= Math.Pow(factors[i],3);
                }
                return product;
        }

        // method to check perfect number
        static bool IsPerfectNumber(int number, int[] factors){
                int sum = 0;

                for(int i=0;i<factors.Length-1;i++){
                        sum += factors[i];
                }

                if(sum == number){
                        return true;
                }else{
                        return false;
                }
        }

        // method to check abundant number
        static bool IsAbundantNumber(int number, int[] factors){
                int sum = 0;

                for(int i=0;i<factors.Length-1;i++){
                        sum += factors[i];
                }

                if(sum > number){
                        return true;
                }else{
                        return false;
                }
        }

        // method to check deficient number
        static bool IsDeficientNumber(int number, int[] factors){
                int sum = 0;

                for(int i=0;i<factors.Length-1;i++){
                        sum += factors[i];
                }

                if(sum < number){
                        return true;
                }else{
                        return false;
                }
        }

        // method to check strong number
        static bool IsStrongNumber(int number){
                int temp = number;
                int sum = 0;

                while(temp != 0){
                        int digit = temp % 10;
                        int fact = 1;

                        for(int i=1;i<=digit;i++){
                                fact *= i;
                        }

                        sum += fact;
                        temp = temp / 10;
                }

                if(sum == number){
                        return true;
                }else{
                        return false;
                }
        }

        static void Main(string[] args){

                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                int[] factors = FindFactors(number);

                Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
                Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));
                Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));
                Console.WriteLine("Product of Cube of Factors: " + FindProductOfCubeOfFactors(factors));

                if(IsPerfectNumber(number,factors)){
                        Console.WriteLine("It is a Perfect number");
                }else{
                        Console.WriteLine("It is not a Perfect number");
                }

                if(IsAbundantNumber(number,factors)){
                        Console.WriteLine("It is an Abundant number");
                }else{
                        Console.WriteLine("It is not an Abundant number");
                }

                if(IsDeficientNumber(number,factors)){
                        Console.WriteLine("It is a Deficient number");
                }else{
                        Console.WriteLine("It is not a Deficient number");
                }

                if(IsStrongNumber(number)){
                        Console.WriteLine("It is a Strong number");
                }else{
                        Console.WriteLine("It is not a Strong number");
                }
        }
}

