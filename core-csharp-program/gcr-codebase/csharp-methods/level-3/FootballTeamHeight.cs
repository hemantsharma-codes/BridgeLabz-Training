using System;
class FootballTeamHeight{
        // method to find sum of heights
        static int FindSum(int[] heights){
                int sum = 0;
                for(int i=0;i<heights.Length;i++){
                        sum = sum + heights[i];
                }
                return sum;
        }

        // method to calculate mean height
        static double FindMean(int[] heights){
                int sum = FindSum(heights);
                double mean = (double)sum / heights.Length;
                return mean;
        }

        // method to find shortest height
        static int FindShortest(int[] heights){
                int min = heights[0];
                for(int i=1;i<heights.Length;i++){
                        if(heights[i] < min){
                                min = heights[i];
                        }
                }
                return min;
        }

        // method to find tallest height
        static int FindTallest(int[] heights){
                int max = heights[0];
                for(int i=1;i<heights.Length;i++){
                        if(heights[i] > max){
                                max = heights[i];
                        }
                }
                return max;
        }

        static void Main(string[] args){

                // array to store heights of 11 players
                int[] heights = new int[11];
                Random random = new Random();

                // generating random heights between 150 and 250
                for(int i=0;i<heights.Length;i++){
                        heights[i] = random.Next(150,251);
                }

                int sum = FindSum(heights);
                double meanHeight = FindMean(heights);
                int shortest = FindShortest(heights);
                int tallest = FindTallest(heights);

                // displaying heights
                Console.WriteLine("Heights of players:");
                for(int i=0;i<heights.Length;i++){
                        Console.WriteLine(heights[i]);
                }

                // displaying final results
                Console.WriteLine("Mean height is "+meanHeight);
                Console.WriteLine("Shortest height is "+shortest);
                Console.WriteLine("Tallest height is "+tallest);
        }
}

