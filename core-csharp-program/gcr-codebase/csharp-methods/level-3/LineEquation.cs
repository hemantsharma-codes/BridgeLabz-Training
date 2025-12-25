using System;
class LineEquation{
        // method to calculate Euclidean distance
        static double FindDistance(double x1,double y1,double x2,double y2){
                double dx = x2 - x1;
                double dy = y2 - y1;

                double distance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
                return distance;
        }

        // method to calculate slope and y-intercept
        static double[] FindLineEquation(double x1,double y1,double x2,double y2){
                double[] result = new double[2];

                double slope = (y2 - y1) / (x2 - x1);
                double intercept = y1 - slope * x1;

                result[0] = slope;
                result[1] = intercept;

                return result;
        }

        static void Main(string[] args){

                // take input for first point
                Console.WriteLine("Enter x1:");
                double x1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter y1:");
                double y1 = double.Parse(Console.ReadLine());

                // take input for second point
                Console.WriteLine("Enter x2:");
                double x2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter y2:");
                double y2 = double.Parse(Console.ReadLine());

                // calculate distance
                double distance = FindDistance(x1, y1, x2, y2);

                // calculate line equation
                double[] equation = FindLineEquation(x1, y1, x2, y2);

                Console.WriteLine("Euclidean Distance = " + distance);
                Console.WriteLine("Equation of Line: y = " + equation[0] + " * x + " + equation[1]);
        }
}

