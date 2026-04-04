using System;
class BonusCalculator{
	static void Main(String[] args){

		// create a varible of employees' number
		int employeesNumber = 10;

		// create arrays to store data
		double[] salary = new double[employeesNumber];
		double[] yearsOfService = new double[employeesNumber];
		double[] newSalary = new double[employeesNumber];
		double[] bonusAmt = new double[employeesNumber];

		double totalBonus = 0.0;
		double totalOldSalary = 0.0;
		double totalNewSalary = 0.0;


		// input loop

		for(int i=0;i<employeesNumber;i++){

			Console.WriteLine("Enter the salary of "+(i+1)+" employee :");
			double sal = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter the years of service of "+(i+1)+" employee :");
			double years = double.Parse(Console.ReadLine());

			if(sal <= 0 || years < 0){
				Console.WriteLine("Invalid input! please take valid input :");
				i--;
				continue;
			}

			salary[i] = sal;
			yearsOfService[i] = years;
		}

		// calculation of bonus amount

		for(int i=0;i<employeesNumber;i++){
			if(yearsOfService[i] > 5){
				double bonus = 0.05*salary[i];
				bonusAmt[i] = bonus;
				newSalary[i] = bonus+salary[i];
			}
			else{
				double bonus = 0.02*salary[i];
				bonusAmt[i] = bonus;
				newSalary[i] = bonus+salary[i];
			}
			totalBonus += bonusAmt[i];
			totalNewSalary += newSalary[i];
			totalOldSalary += salary[i];
		}

		// display the output

		Console.WriteLine("Total bonus of employees :"+totalBonus);
		Console.WriteLine("Total old salary of employees :"+totalOldSalary);
		Console.WriteLine("Total new salay of employees :"+totalNewSalary);

	}
}
