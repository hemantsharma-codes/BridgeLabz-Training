using System;
class TotalPriceCalculator{
	static void Main(String[] args){
		
		Console.WriteLine("Enter the unit price of an item :");
		double unitPrice = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the quantity to be bought :");
		double quantity = double.Parse(Console.ReadLine());

		double totalPrice = unitPrice * quantity;

		Console.WriteLine("The total purchase price is INR"+totalPrice+" if the quantity "+quantity+" unit price is INR"+unitPrice);
	}
}

