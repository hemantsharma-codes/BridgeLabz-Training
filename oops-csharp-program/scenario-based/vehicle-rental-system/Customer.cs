using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Customer
    {
        private string name;
        private Vehicle rentedVehicle;

        public Customer(string name, Vehicle vehicle)
        {
            this.name = name;
            this.rentedVehicle = vehicle;
        }

        public void ShowBill(int days)
        {
            Console.WriteLine($"Customer: {name}");
            Console.WriteLine(rentedVehicle);
            Console.WriteLine($"Total Rent for {days} days: ₹{rentedVehicle.CalculateRent(days)}");
        }
    }

}
