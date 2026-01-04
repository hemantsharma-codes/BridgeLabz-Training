using System;
class CarRental{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double totalCost;

    // Default constructor
    public CarRental(){
        customerName = "Not Assigned";
        carModel = "Standard";
        rentalDays = 1;
        totalCost = CalculateCost();
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        totalCost = CalculateCost();
    }

    // Copy constructor
    public CarRental(CarRental cr){
        customerName = cr.customerName;
        carModel = cr.carModel;
        rentalDays = cr.rentalDays;
        totalCost = cr.totalCost;
    }

    // Method to calculate total cost
    private double CalculateCost(){
        double ratePerDay;

        switch (carModel.ToLower()){
            case "sedan":
                ratePerDay = 1500;
                break;
            case "suv":
                ratePerDay = 2500;
                break;
            case "luxury":
                ratePerDay = 4000;
                break;
            default:
                ratePerDay = 1000;
                break;
        }

        return ratePerDay * rentalDays;
    }

    // Display method
    public void Display(){
        Console.WriteLine("Customer Name : " + customerName);
        Console.WriteLine("Car Model     : " + carModel);
        Console.WriteLine("Rental Days   : " + rentalDays);
        Console.WriteLine("Total Cost    : ₹" + totalCost);
    }
}

class CarRentalDemo{
    static void Main(){
        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Car Model (Sedan / SUV / Luxury): ");
        string model = Console.ReadLine();

        Console.Write("Enter Rental Days: ");
        int days = int.Parse(Console.ReadLine());

        // Parameterized object
        CarRental r1 = new CarRental(name, model, days);

        // Copy object
        CarRental r2 = new CarRental(r1);

        Console.WriteLine("\nOriginal Rental Details:");
        r1.Display();

        Console.WriteLine("\nCopied Rental Details:");
        r2.Display();
    }
}

