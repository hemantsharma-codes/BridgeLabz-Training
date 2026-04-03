using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Bike : Vehicle
    {
        public Bike(string vehicleNumber, string brand)
            : base(vehicleNumber, brand, 300) { }

        public override double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }

}
