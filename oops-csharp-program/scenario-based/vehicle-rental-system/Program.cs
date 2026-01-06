using System;
using VehicleRentalSystem;
class Program
{
    static void Main(String[] args)
    {
        Vehicle car = new Car("UP32AB1234", "Honda");
        Customer customer = new Customer("Hemant", car);

        customer.ShowBill(5);
    }
}