using System;
class IntOperation{
    static void Main(String[] args){

        Console.WriteLine("Enter value of a :");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of b :");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter value of c :");
        int c = int.Parse(Console.ReadLine());

        int operation1 = a + b * c;
        int operation2 = a * b + c;
        int operation3 = c + a / b;
        int operation4 = a % b + c;

        Console.WriteLine("The results of Int Operations are "+operation1+", "+operation2+", "+operation3+", and "+operation4);
    }
}

