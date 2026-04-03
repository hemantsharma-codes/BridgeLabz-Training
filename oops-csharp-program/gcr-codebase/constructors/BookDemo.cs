using System;
class Book{
	private string title;
	private string author;
	private int price;

	internal Book(){
		this.title = "ALL THE LIGHT WE CANNOT SEE";
		this.author = "Gaurav Chaudhry";
		this.price = 200;
	}
	internal Book(string title,string author,int price){
		this.title = title;
		this.author = author;
		this.price = price;
	}

	public string getTitle(){
		return this.title;
	}
	public string getAuthor(){
		return this.author;
	}
	public int getPrice(){
		return this.price;
	}
}
class BookDemo{
	static void Main(string[] args){
		Console.WriteLine("Enter the title : ");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the author : ");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the price of the book : ");
                int price = int.Parse(Console.ReadLine());

		// call for default constructor
		Book book = new Book();
		Console.WriteLine("\n Default Constructor is calling : \n");
		Console.WriteLine("Title : "+book.getTitle()+"\t Author : "+book.getAuthor()+"\t Price : "+book.getPrice());

		// call for parameterized constructor
		Console.WriteLine("\n Paramterized constructor is calling ");
		Book book2 = new Book(title,author,price);
		
		Console.WriteLine("Title : "+book2.getTitle()+"\t Author : "+book2.getAuthor()+"\t Price : "+book2.getPrice());

	}
}
