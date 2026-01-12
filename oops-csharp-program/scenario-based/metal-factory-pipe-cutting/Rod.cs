using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipeCutting
{
    internal class Rod
    {
        private int RodLength = 8;
        private int[] RodPrice = { 1, 3, 2, 5, 8, 9, 4, 6 };

        private CutCalculator cutCalculator;


        public int GetRodLength()
        {
            return this.RodLength;
        }
        public int GetPrice(int length)
        {
            return this.RodPrice[length-1];
        }


    }

}
