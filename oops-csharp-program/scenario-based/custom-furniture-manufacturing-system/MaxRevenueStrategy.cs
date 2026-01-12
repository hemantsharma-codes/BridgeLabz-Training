using System;

namespace CustomFurtnitureManufacturing
{
    internal class MaxRevenueStrategy : CutStrategy
    {
        public override int CalculateResult(WoodRod rod)
        {
            // start recursion with full length of rod
            return MaxEarning(rod, rod.GetWoodRodSize());
        }

        private int MaxEarning(WoodRod rod, int remainingLength)
        {
            // BASE CASE
            if (remainingLength == 0)
                return 0;

            int maxRevenue = 0;

            // Try all possible cuts
            for (int cut = 1; cut <= remainingLength; cut++)
            {
                int currentRevenue =rod.GetWoodRodPrice(cut)+MaxEarning(rod, remainingLength - cut);

                if (currentRevenue > maxRevenue)
                    maxRevenue = currentRevenue;
            }

            return maxRevenue;
        }
    }
}
