using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Truck : Vehicle
    {
        public Truck(string vehicleNumber, string brand)
            : base(vehicleNumber, brand, 1500) { }

        public override double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }

}
