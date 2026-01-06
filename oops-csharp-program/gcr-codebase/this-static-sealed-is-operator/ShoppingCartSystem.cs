using System;
class Product
{
    // static: shared discount
    public static double Discount;

    // readonly: cannot be changed
    public readonly int ProductID;

    // public fields
    public string ProductName;
    public double Price;
    public int Quantity;

    // static constructor
    static Product()
    {
        Discount = 10;
    }

    // static method
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    // constructor using this
    public Product(int productID, string productName, double price, int quantity)
    {
        this.ProductID = productID;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public void Display()
    {
        double total = Price * Quantity;
        double finalPrice = total - (total * Discount / 100);

        Console.WriteLine("Product ID   : " + ProductID);
        Console.WriteLine("Product Name : " + ProductName);
        Console.WriteLine("Price        : " + Price);
        Console.WriteLine("Quantity     : " + Quantity);
        Console.WriteLine("Discount     : " + Discount + "%");
        Console.WriteLine("Final Price  : " + finalPrice);
    }
}
class ShoppingCartSystem{  
    static void Main(string[] args){

        // update discount
        Product.UpdateDiscount(15);

        // object reference
        object obj = new Product(201, "Mobile Phone", 20000, 2);

        // is operator check
        if (obj is Product)
        {
            Product p = (Product)obj;
            p.Display();
        }
        else
        {
            Console.WriteLine("Not a valid product");
        }
    }
}
