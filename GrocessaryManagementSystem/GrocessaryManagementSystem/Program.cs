using System;
class Program
{
    static void Main()
    {
        // Arrays to store items and prices
        string[] items = { "Rice", "Wheat", "Sugar", "Milk", "Oil" };
        double[] prices = { 60, 50, 40, 30, 120 };

        double totalAmount = 0;
        char choice;

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i} : {items[i]} - Rs {prices[i]}");
        }

        do
        {
            Console.Write("\nEnter item index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double itemCost = prices[index] * quantity;
            totalAmount += itemCost;

            Console.Write("Do you want to buy more items? (y/n): ");
            choice = Convert.ToChar(Console.ReadLine());

        } while (choice == 'y' || choice == 'Y');

        // Discount logic
        double discount = 0;
        if (totalAmount >= 500)
        {
            discount = totalAmount * 0.10; // 10% discount
        }

        double finalAmount = totalAmount - discount;

        Console.WriteLine("\n---- Bill Summary ----");
        Console.WriteLine("Total Amount : Rs " + totalAmount);
        Console.WriteLine("Discount     : Rs " + discount);
        Console.WriteLine("Final Amount : Rs " + finalAmount);
    }
}
