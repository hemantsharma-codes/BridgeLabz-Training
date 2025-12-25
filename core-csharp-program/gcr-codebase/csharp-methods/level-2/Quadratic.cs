using System;
class Quadratic{
    static double[] FindRoots(double a, double b, double c){
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if(delta < 0){
            return new double[0];   // empty array
        }

        if(delta == 0){
            double root = -b/(2*a);
            return new double[] {root};
        }

        double sqrtDelta = Math.Sqrt(delta);

        double root1 = (-b+sqrtDelta)/(2*a);
        double root2 = (-b-sqrtDelta)/(2*a);

        return new double[] {root1,root2};
    }

    static void Main(string[] args){
        // take input
        Console.WriteLine("Enter value of a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of c:");
        double c = double.Parse(Console.ReadLine());

        // call method
        double[] roots = FindRoots(a, b, c);

        // display result
        if(roots.Length == 0){
            Console.WriteLine("No real roots exist.");
        }
        else if(roots.Length == 1){
            Console.WriteLine("Only one root exists: " + roots[0]);
        }
        else{
            Console.WriteLine("Root 1 = " + roots[0]);
            Console.WriteLine("Root 2 = " + roots[1]);
        }
    }
}

