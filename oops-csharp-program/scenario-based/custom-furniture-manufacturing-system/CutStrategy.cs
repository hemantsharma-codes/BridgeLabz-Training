using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFurtnitureManufacturing
{
    abstract class CutStrategy
    {
        public abstract int CalculateResult(WoodRod rod);
    }
}
