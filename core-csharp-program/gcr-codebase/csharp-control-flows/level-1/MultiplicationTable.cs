using System;
class MultiplicationTable{
    static void Main(string[] args){

        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++){

            Console.WriteLine(number+" * "+i+" = "+(number * i));

        }
    }
}

