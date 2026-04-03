using System;

class Vehicle{
    // Instance variables
    private string ownerName;
    private string vehicleType;

    // Class variable (shared by all vehicles)
    private static double registrationFee = 1500;

    // Parameterized constructor
    public Vehicle(string ownerName, string vehicleType){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method
    public void DisplayVehicleDetails(){
        Console.WriteLine("Owner Name        : " + ownerName);
        Console.WriteLine("Vehicle Type      : " + vehicleType);
        Console.WriteLine("Registration Fee  : " + registrationFee);
    }

    // Class (static) method
    public static void UpdateRegistrationFee(double newFee){
        registrationFee = newFee;
    }
}
class VehicleRegistration{
    static void Main(string[] args){
        // Create vehicle objects
        Vehicle v1 = new Vehicle("Hemant Sharma", "Car");
        Vehicle v2 = new Vehicle("Amit Kumar", "Bike");

        Console.WriteLine("Vehicle Details (Before Fee Update):");
        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();

        // Update registration fee
        Console.Write("\nEnter New Registration Fee: ");
        double newFee = double.Parse(Console.ReadLine());
        Vehicle.UpdateRegistrationFee(newFee);

        Console.WriteLine("\nVehicle Details (After Fee Update):");
        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();
    }
}

