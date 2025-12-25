using System;
class BMICalculator{
    static void CalculateBMI(double[,] personData){
        for(int i=0;i<personData.GetLength(0);i++){
            double weight = personData[i, 0];       // in kg
            double heightCm = personData[i, 1];     // in cm

            double heightMeter = heightCm / 100;    // convert cm to meter
            double bmi = weight / (heightMeter * heightMeter);

            personData[i, 2] = bmi;                  // store BMI
        }
    }
    static string[] DetermineBMIStatus(double[,] personData){
        string[] status = new string[personData.GetLength(0)];

        for(int i=0;i<personData.GetLength(0);i++){
            double bmi = personData[i, 2];

            if (bmi < 18.5)
                status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                status[i] = "Normal";
            else if (bmi >= 25 && bmi < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
        return status;
    }

    static void Main(string[] args){
        // 2D array with 10 rows, 3 columns (weight, height, BMI)
        double[,] personData = new double[10, 3];

        // take input
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Enter details for Person "+(i+1));

            Console.Write("Weight (kg): ");
            personData[i,0] = double.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            personData[i,1] = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        // calculate BMI
        CalculateBMI(personData);

        // get BMI status
        string[] bmiStatus = DetermineBMIStatus(personData);

        // display result
        Console.WriteLine("Weight\tHeight\tBMI\t\tStatus");

        for (int i = 0; i < 10; i++){
            Console.WriteLine(personData[i,0]+"\t"+personData[i,1]+"\t"+Math.Round(personData[i,2],2)+"\t\t"+bmiStatus[i]);
        }
    }
}

