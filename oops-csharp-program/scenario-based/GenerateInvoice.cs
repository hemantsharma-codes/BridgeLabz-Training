using System;
class GenerateInvoice{
	static void Main(string[] args){
		GenerateInvoice generateInvoice = new GenerateInvoice();
		generateInvoice.StartApp();
	}
	private void StartApp(){

		Console.WriteLine("/=========== Invoice Generator ====================/");
		Console.WriteLine("Enter the input string : ");
		string input = Console.ReadLine();

		// Parse invoice
		string[] enteries = input.Split(',');
		string[] items = new string[enteries.Length];
		int[] prices = new int[enteries.Length];

		ParseInvoice(enteries,items,prices);

		Console.WriteLine("items\t\t\t price");
		for(int i=0;i<items.Length;i++){
			Console.WriteLine(items[i]+"\t\t"+prices[i]);
		}

		int totalAmount = GetTotalAmount(prices);

		Console.WriteLine("\nThe total amount is "+totalAmount);


	}
	private void ParseInvoice(string[] enteries,string[] items,int[] prices){

		for(int i=0;i<enteries.Length;i++){
			
			// split enteries based on hype
			string entry = enteries[i].Trim();
			string[] parts = entry.Split('-');

			items[i] = parts[0].Trim();

			string pricePart = parts[1].Replace("INR","").Trim();
			prices[i] = int.Parse(pricePart);

		}


	}
	private int GetTotalAmount(int[] prices){

		int totalPrice = 0;
		for(int i=0;i<prices.Length;i++){
			totalPrice += prices[i];
		}
		return totalPrice;
	}
}
