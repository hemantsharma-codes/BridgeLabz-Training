using System;

namespace MetalFactoryPipeCutting
{
    internal class RevenueComparison
    {
        private int optimalRevenue;
        private int nonOptimalRevenue;

        public void SetOptimalRevenue(int revenue)
        {
            optimalRevenue = revenue;
        }

        public void SetNonOptimalRevenue(int revenue)
        {
            nonOptimalRevenue = revenue;
        }

        public void DisplayComparison()
        {
            Console.WriteLine("\n--- Revenue Comparison ---");
            Console.WriteLine("Optimized Strategy Revenue     : " + optimalRevenue);
            Console.WriteLine("Non-Optimized Strategy Revenue : " + nonOptimalRevenue);
            Console.WriteLine("Revenue Loss                  : " + (optimalRevenue - nonOptimalRevenue));
        }
    }
}
