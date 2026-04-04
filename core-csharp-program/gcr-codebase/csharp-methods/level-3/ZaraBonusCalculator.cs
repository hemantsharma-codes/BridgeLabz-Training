using System;
class ZaraBonusCalculator{
        // method to generate salary and years of service
        static double[,] GenerateEmployeeData(int size){
                double[,] data = new double[size,2];
                Random random = new Random();

                for(int i=0;i<size;i++){
                        // generate 5 digit salary
                        data[i,0] = random.Next(10000, 100000);

                        // generate years of service (1 to 10)
                        data[i,1] = random.Next(1, 11);
                }
                return data;
        }

        // method to calculate new salary and bonus
        static double[,] CalculateBonus(double[,] employeeData){
                int size = employeeData.GetLength(0);
                double[,] result = new double[size,3];

                for(int i=0;i<size;i++){
                        double salary = employeeData[i,0];
                        double years = employeeData[i,1];
                        double bonus;

                        if(years > 5){
                                bonus = salary * 0.05;
                        }else{
                                bonus = salary * 0.02;
                        }

                        double newSalary = salary + bonus;

                        result[i,0] = salary;
                        result[i,1] = bonus;
                        result[i,2] = newSalary;
                }
                return result;
        }

        // method to display totals in tabular format
        static void DisplaySummary(double[,] data){
                double totalOldSalary = 0;
                double totalBonus = 0;
                double totalNewSalary = 0;

                Console.WriteLine("Emp\tOldSalary\tBonus\t\tNewSalary");
                Console.WriteLine("-----------------------------------------------");

                for(int i=0;i<data.GetLength(0);i++){
                        Console.WriteLine((i+1) + "\t"+(int)data[i,0]+"\t\t"+(int)data[i,1]+"\t\t"+(int)data[i,2]);

                        totalOldSalary += data[i,0];
                        totalBonus += data[i,1];
                        totalNewSalary += data[i,2];
                }

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Total\t"+(int)totalOldSalary+"\t\t"+(int)totalBonus+"\t\t"+(int)totalNewSalary);
        }

        static void Main(string[] args){

                int numberOfEmployees = 10;

                // generate employee salary and service data
                double[,] employeeData = GenerateEmployeeData(numberOfEmployees);

                // calculate bonus and new salary
                double[,] finalData = CalculateBonus(employeeData);

                // display result
                DisplaySummary(finalData);
        }
}

