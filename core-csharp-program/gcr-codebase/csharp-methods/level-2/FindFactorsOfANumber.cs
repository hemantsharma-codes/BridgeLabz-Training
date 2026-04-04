using System;
class FindFactorsOfANumber{
	static int[] FindFactors(int number){

		// count total number of factors 
		int count = 0;
		for(int i=1;i<=number;i++){
			if(number%i == 0){
				count++;
			}
		}

		// creating an array to store factors of number
		int[] factors = new int[count];
		int idx = 0;

		for(int i=1;i<=number;i++){
			if(number%i == 0){
				factors[idx++] = i;
			}
		}
		return factors;
	}
	static int SumOfFactors(int[] factors){

		int sum = 0;
		for(int i=0;i<factors.Length;i++){
			sum += factors[i];
		}
		return sum;
	}
	static int ProductOfFactors(int[] factors){
		int product = 1;
		for(int i=0;i<factors.Length;i++){
			product *= factors[i];
		}
		return product;
	}
	static int SumOfSqOfFactors(int[] factors){
		int sumOfSq = 0;

		for(int i=0;i<factors.Length;i++){
			sumOfSq += (int)Math.Pow(factors[i],2);
		}
		return sumOfSq;
	}

	static void Main(String[] args){

		Console.WriteLine("Enter the number :");
		int number = int.Parse(Console.ReadLine());

		// find factors
		int[] factors = FindFactors(number);

		int sumOfFactors = SumOfFactors(factors);
		int productOfFactors = ProductOfFactors(factors);
		int sumOfSqOfFactors = SumOfSqOfFactors(factors);

		Console.WriteLine("Sum of factors = "+sumOfFactors+", Product of factors = "+productOfFactors+", and Sum of square of factors = "+sumOfSqOfFactors);
	}
}
