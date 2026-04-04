using System;
class FactorOfNumber{
	static void Main(String[] args){

		// take a number input
		Console.WriteLine("Enter a number :");
		int number = int.Parse(Console.ReadLine());

		// create a maxFactor and initialize with 10
		int maxFactor = 10;
		int[] factorsArr = new int[maxFactor];
		int idx = 0;

		// Find factors
		for(int i=1;i<=number;i++){
			if(number%i == 0){

				if(idx == maxFactor){
					maxFactor = maxFactor*2;
					int[] temp = new int[maxFactor];

					for(int j=0;j<factorsArr.Length;j++){
						temp[j] = factorsArr[j];
					}

					factorsArr = temp;
				}

				factorsArr[idx] = i;
				idx++;
			}
		}

		// display factors
		Console.WriteLine("Factors of "+number+" are :");
		for(int i=0;i<idx;i++){
			Console.WriteLine(factorsArr[i]+"");
		}
	}
}
