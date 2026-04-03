using System;

// Main class
public class MathTools {

        static void Main(string[] args) {
                StartApplication();
        }

        static void StartApplication() {

                Console.WriteLine("1. Calculate the factorial of a number");
                Console.WriteLine("2. Check whether a number is prime or not");
                Console.WriteLine("3. Find the greatest common divisor of two numbers");
                Console.WriteLine("4. Find the nth Fibonacci number");

                Console.WriteLine("\nPlease select the correct choice:");
                int userChoice = int.Parse(Console.ReadLine());

                switch(userChoice) {

                        case 1:
                                Console.WriteLine("Enter a number:");
                                int factorialNumber = int.Parse(Console.ReadLine());
                                MathematicalOperations.FactorialCalculator(factorialNumber);
                                break;

                        case 2:
                                Console.WriteLine("Enter a number:");
                                int primeNumber = int.Parse(Console.ReadLine());

                                if(MathematicalOperations.IsPrime(primeNumber)) {
                                        Console.WriteLine(primeNumber + " is a prime number.");
                                }
                                else {
                                        Console.WriteLine(primeNumber + " is not a prime number.");
                                }
                                break;

                        case 3:
                                Console.WriteLine("Enter first number:");
                                int firstNumber = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter second number:");
                                int secondNumber = int.Parse(Console.ReadLine());

                                MathematicalOperations.FindGCD(firstNumber, secondNumber);
                                break;

                        case 4:
                                Console.WriteLine("Enter position:");
                                int position = int.Parse(Console.ReadLine());
                                MathematicalOperations.FindFibonacciNumber(position);
                                break;

                        default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                }
        }
}

// Utility class
internal class MathematicalOperations {

        internal static void FactorialCalculator(int number) {

                if(number < 0) {
                        Console.WriteLine("Factorial is not defined for negative numbers.");
                        return;
                }

                int factorialResult = 1;
                for(int index = 1; index <= number; index++) {
                        factorialResult *= index;
                }

                Console.WriteLine("Factorial of " + number + " is " + factorialResult);
        }

        internal static bool IsPrime(int number) {

                if(number <= 1)
                        return false;

                for(int divisor = 2; divisor * divisor <= number; divisor++) {
                        if(number % divisor == 0)
                                return false;
                }

                return true;
        }

        internal static void FindGCD(int firstNumber, int secondNumber) {

                if(firstNumber < 0) firstNumber = -firstNumber;
                if(secondNumber < 0) secondNumber = -secondNumber;

                while(secondNumber != 0) {
                        int remainder = firstNumber % secondNumber;
                        firstNumber = secondNumber;
                        secondNumber = remainder;
                }

                Console.WriteLine("Greatest Common Divisor is: " + firstNumber);
        }

        internal static void FindFibonacciNumber(int position) {

                if(position < 0) {
                        Console.WriteLine("Invalid position.");
                        return;
                }

                if(position == 0) {
                        Console.WriteLine("Fibonacci number is: 0");
                        return;
                }

                long previousNumber = 0;
                long currentNumber = 1;

                for(int index = 2; index <= position; index++) {
                        long nextNumber = previousNumber + currentNumber;
                        previousNumber = currentNumber;
                        currentNumber = nextNumber;
                }

                Console.WriteLine("The " + position + "th Fibonacci number is: " + currentNumber);
        }
}

