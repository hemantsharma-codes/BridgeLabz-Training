using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipeCutting
{
    internal class GivenCutCalculator : CutCalculator
    {
        private int[] cuts;
        public GivenCutCalculator(int[] cuts)
        {
            this.cuts = cuts;
        }
        public override int CalculateRevenue(Rod rod)
        {
            int revenue = 0;
            for(int i = 0; i < cuts.Length; i++)
            {
                revenue += rod.GetPrice(cuts[i]);
            }
            return revenue;
        }

    }
}
