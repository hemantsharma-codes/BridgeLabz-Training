using System;
class NaturalNum2WithForLoop{
        static void Main(String[] args){

                Console.WriteLine("Enter the number :");
                int number = int.Parse(Console.ReadLine());

                if(number > 0){

                        int formulaSum = (number*(number+1))/2;

                        int loopSum = 0;

                        for(int i=number;i>0;i--){
				loopSum += i;
			}

                        if(formulaSum == loopSum){
                                Console.WriteLine("formula result "+formulaSum+" and loop result "+loopSum+" are equal");
                        }
                        else{
                                Console.WriteLine("Both results are not eqaul.");
                        }
                }
                else{
                        Console.WriteLine("Number is not positive");
                }
        }
}


