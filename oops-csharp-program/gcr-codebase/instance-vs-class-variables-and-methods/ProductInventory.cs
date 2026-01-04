using System;
class Product{
    // Instance variables
    private string productName;
    private double price;

    // Class variable (shared)
    private static int totalProducts = 0;

    // Parameterized constructor
    public Product(string productName, double price){
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Instance method
    public void DisplayProductDetails(){
        Console.WriteLine("Product Name : " + productName);
        Console.WriteLine("Price        : " + price);
    }

    // Class (static) method
    public static void DisplayTotalProducts(){
        Console.WriteLine("Total Products Created : " + totalProducts);
    }
}
class ProductInventory{
    static void Main(string[] args){
        Console.Write("Enter Product 1 Name: ");
        string name1 = Console.ReadLine();

        Console.Write("Enter Product 1 Price: ");
        double price1 = double.Parse(Console.ReadLine());

        Product p1 = new Product(name1, price1);

        Console.Write("\nEnter Product 2 Name: ");
        string name2 = Console.ReadLine();

        Console.Write("Enter Product 2 Price: ");
        double price2 = double.Parse(Console.ReadLine());

        Product p2 = new Product(name2, price2);

        Console.WriteLine("\nProduct Details:");
        p1.DisplayProductDetails();
        Console.WriteLine();
        p2.DisplayProductDetails();

        Console.WriteLine();
        Product.DisplayTotalProducts();
    }
}

