using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem{  
    public abstract class Vehicle : IRentable{
        protected string vehicleNumber;
        protected string brand;
        protected double ratePerDay;

        public Vehicle(string vehicleNumber, string brand, double ratePerDay)
        {
            this.vehicleNumber = vehicleNumber;
            this.brand = brand;
            this.ratePerDay = ratePerDay;
        }

        public abstract double CalculateRent(int days);

        public override string ToString()
        {
            return $"Vehicle No: {vehicleNumber}, Brand: {brand}, Rate/Day: {ratePerDay}";
        }
    }

}
