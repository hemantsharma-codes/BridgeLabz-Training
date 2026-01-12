using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipeCutting
{
    abstract class CutCalculator
    {
        public abstract int CalculateRevenue(Rod rod);
    }
}
