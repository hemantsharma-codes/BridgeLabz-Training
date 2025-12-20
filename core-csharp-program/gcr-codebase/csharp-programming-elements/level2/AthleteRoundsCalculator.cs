using System;
class AthleteRoundsCalculator{
    static void Main(String[] args){

        Console.WriteLine("Enter side 1 of the triangular park (in meters):");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 2 of the triangular park (in meters):");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 3 of the triangular park (in meters):");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000; // 5 km in meters

        double rounds = totalDistance / perimeter;

        Console.WriteLine("The total numbers of rounds the athlete will run is "+rounds+" to complete 5km");
    }
}

