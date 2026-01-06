using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Car : Vehicle
    {
        public Car(string vehicleNumber, string brand)
            : base(vehicleNumber, brand, 800) { }

        public override double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
    }

}
