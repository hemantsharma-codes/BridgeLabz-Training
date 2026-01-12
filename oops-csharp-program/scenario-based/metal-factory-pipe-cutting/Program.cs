using System;

namespace MetalFactoryPipeCutting
{
    class Program
    {

        static void Main(string[] args)
        {
            Rod rod = new Rod();
            CutCalculator calculator;
            RevenueComparison revenueComparison = new RevenueComparison();

            while (true)
            {
                Console.WriteLine("\n1. Optimal Cut");
                Console.WriteLine("2. Given Cut");
                Console.WriteLine("3. Visualize revenue");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        calculator = new OptimalCutCalculator();
                        int revenue = calculator.CalculateRevenue(rod);
                        revenueComparison.SetOptimalRevenue(revenue);
                        break;

                    case 2:
                        calculator = new GivenCutCalculator(new int[] { 3, 3, 2 });
                        revenue = calculator.CalculateRevenue(rod);
                        revenueComparison.SetNonOptimalRevenue(revenue);
                        break;

                    case 3:
                        revenueComparison.DisplayComparison();
                        break;
                    case 4:
                        Console.WriteLine("\nExiting......");
                        return;
                }
            }
        }
    }
}
