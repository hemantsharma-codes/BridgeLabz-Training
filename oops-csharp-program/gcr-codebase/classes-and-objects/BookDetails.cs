using System;
class BookDetails{
	private string title;
	private string author;
	private double price;

	private BookDetails(string title,string author,double price){
		this.title = title;
		this.author = author;
		this.price = price;
	}

	protected void DisplayBookDetails(){
		Console.WriteLine("Title : "+title);
		Console.WriteLine("Author : "+author);
		Console.WriteLine("Price : "+price);
	}
	static void Main(String[] args){
		Console.WriteLine("Enter a title of the book : ");
		string title = Console.ReadLine();
		Console.WriteLine("Enter author of the book : ");
		string author = Console.ReadLine();
		Console.WriteLine("Enter the price of the book : ");
		double price = double.Parse(Console.ReadLine());

		BookDetails bookDetails = new BookDetails(title,author,price);

		bookDetails.DisplayBookDetails();
	}
}
