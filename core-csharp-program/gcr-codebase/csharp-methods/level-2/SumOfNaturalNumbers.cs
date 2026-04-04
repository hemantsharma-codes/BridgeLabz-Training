using System;
class SumOfNaturalNumbers{
	static void Main(string[] args){
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());

                // Check if number is a natural number
                if(n<=0){
			Console.WriteLine("Please enter a natural number (greater than 0).");
                        return;
		}

		// Calculate sum using recursion
                int recursiveSum = FindSumUsingRecursion(n);

                // Calculate sum using formula
                int formulaSum = FindSumUsingFormula(n);

                // Display results
                Console.WriteLine("Sum using recursion = "+recursiveSum);
                Console.WriteLine("Sum using formula   = "+formulaSum);

                // Compare results
                if(recursiveSum==formulaSum){
			Console.WriteLine("Both results are correct and equal.");
		}
		else{
			Console.WriteLine("Results are not equal.");
		}
	}
        static int FindSumUsingRecursion(int n)
        {
		if(n==1){
			return 1;
		}
		return n+FindSumUsingRecursion(n-1);
	}

        static int FindSumUsingFormula(int n){
		return n*(n+1)/2;
	}
}

