using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFurtnitureManufacturing
{
    internal class WoodRod
    {
        private int WoodRodSize = 10;
        private int[] WoodRodPrice = {1, 5, 8, 9, 10, 17, 17, 20, 24, 30, 32, 35};

        public int GetWoodRodSize()
        {
            return this.WoodRodSize;
        }
        public int GetWoodRodPrice(int length)
        {
            return WoodRodPrice[length-1];
        }

    }
}
