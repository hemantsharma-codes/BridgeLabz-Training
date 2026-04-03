using System;
using CustomFurtnitureManufacturing;

class WoodMain
{
    private static CutStrategy cutStrategy;

    static void Main(string[] args)
    {
        Console.WriteLine("========== Custom Furniture Manufacturing System ==========");

        WoodRod rod = new WoodRod();
        CutResults result = new CutResults();

        while (true)
        {
            Console.WriteLine("\n1. Determine best cut to maximize earnings (Scenario A)");
            Console.WriteLine("2. Max earnings with fixed waste constraint (Scenario B)");
            Console.WriteLine("3. Balanced strategy (Revenue + Minimal Waste) (Scenario C)");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    cutStrategy = new MaxRevenueStrategy();
                    int maxRevenue = cutStrategy.CalculateResult(rod);
                    result.SetRevenue(maxRevenue);

                    Console.WriteLine("Maximum Revenue: " + maxRevenue);
                    break;

                case 2:
                    cutStrategy = new WasteConstraintedStrategy();
                    int wasteRevenue = cutStrategy.CalculateResult(rod);
                    result.SetRevenue(wasteRevenue);

                    Console.WriteLine("Revenue with Waste Constraint: " + wasteRevenue);
                    break;

                case 3:
                    cutStrategy = new BalanceStrategy();
                    int balancedRevenue = cutStrategy.CalculateResult(rod);
                    result.SetRevenue(balancedRevenue);

                    Console.WriteLine("Balanced Revenue (Revenue + Minimal Waste): " + balancedRevenue);
                    break;

                case 4:
                    Console.WriteLine("Exiting system...");
                    return;
            }
        }
    }
}
