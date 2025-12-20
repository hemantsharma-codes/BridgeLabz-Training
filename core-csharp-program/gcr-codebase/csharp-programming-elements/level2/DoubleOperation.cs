using System;
class DoubleOperation{
    static void Main(String[] args){

        Console.WriteLine("Enter value of a :");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of b :");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of c :");
        double c = double.Parse(Console.ReadLine());

        double operation1 = a + b * c;
        double operation2 = a * b + c;
        double operation3 = c + a / b;
        double operation4 = a % b + c;

        Console.WriteLine("The results of Double Operations are "+operation1+", "+operation2+", "+operation3+", and "+operation4);
    }
}

