using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipeCutting
{
    internal class OptimalCutCalculator : CutCalculator
    {
        private Rod rod;
        public override int CalculateRevenue(Rod rod)
        {
            return MaxRevenue(rod, rod.GetRodLength());
        }
        private int MaxRevenue(Rod rod, int length)
        {
            // Base case
            if (length == 0)
                return 0;

            int max = rod.GetPrice(length); // no cut case

            // Try all possible cuts
            for (int i = 1; i < length; i++)
            {
                int current =
                    MaxRevenue(rod, i) +
                    MaxRevenue(rod, length - i);

                if (current > max)
                    max = current;
            }

            return max;
        }

    }
}
