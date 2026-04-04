using System;
class ChocolateDistribution{
    static void Main(String[] args){

        Console.WriteLine("Enter number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+" and the number of remaining chocolates is "+remainingChocolates);
    }
}

