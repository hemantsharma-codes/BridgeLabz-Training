using System;
class StudentScoreCard{
        // method to generate random PCM marks
        static int[,] GeneratePCMScores(int students){
                int[,] scores = new int[students,3];
                Random random = new Random();

                for(int i=0;i<students;i++){
                        scores[i,0] = random.Next(10, 100); // Physics
                        scores[i,1] = random.Next(10, 100); // Chemistry
                        scores[i,2] = random.Next(10, 100); // Maths
                }
                return scores;
        }

        // method to calculate total, average and percentage
        static double[,] CalculateResults(int[,] scores){
                int students = scores.GetLength(0);
                double[,] result = new double[students,3];

                for(int i=0;i<students;i++){
                        int total = scores[i,0] + scores[i,1] + scores[i,2];
                        double average = total / 3.0;
                        double percentage = (total / 300.0) * 100;

                        result[i,0] = total;
                        result[i,1] = Math.Round(average, 2);
                        result[i,2] = Math.Round(percentage, 2);
                }
                return result;
        }

        // method to display scorecard
        static void DisplayScoreCard(int[,] scores,double[,] result){
                Console.WriteLine("Stu\tPhy\tChem\tMath\tTotal\tAvg\tPercent");
                Console.WriteLine("-------------------------------------------------------");

                for(int i=0;i<scores.GetLength(0);i++){
                        Console.WriteLine((i+1) +"\t"+scores[i,0]+"\t"+scores[i,1]+"\t"+scores[i,2]+"\t"+result[i,0]+"\t"+result[i,1]+"\t"+result[i,2]);
                }
        }

        static void Main(string[] args){

                Console.WriteLine("Enter number of students:");
                int students = int.Parse(Console.ReadLine());

                // generate PCM scores
                int[,] scores = GeneratePCMScores(students);

                // calculate results
                double[,] result = CalculateResults(scores);

                // display scorecard
                DisplayScoreCard(scores, result);
        }
}

