using System.Threading.Channels;

namespace CustomFurtnitureManufacturing
{
    internal class WasteConstraintedStrategy : CutStrategy
    {
        private int maxWaste = 2;

        public override int CalculateResult(WoodRod rod)
        {
            return MaxEarningWithWaste(rod, rod.GetWoodRodSize());
        }

        private int MaxEarningWithWaste(WoodRod rod, int remaining)
        {
            if (remaining <= maxWaste)
                return 0;

            int maxRevenue = 0;

            for (int cut = 1; cut <= remaining - maxWaste; cut++)
            {
                int revenue =rod.GetWoodRodPrice(cut)+MaxEarningWithWaste(rod, remaining - cut);

                if (revenue > maxRevenue)
                    maxRevenue = revenue;
            }

            return maxRevenue;
        }
    }
}
