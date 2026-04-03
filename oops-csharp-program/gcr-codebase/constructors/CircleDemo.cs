using System;
class Circle{
	private double radius;

	// default constructor 
	internal Circle() : this(2.00){ // constructor chaining

	}
	// parameterized constructor
	internal Circle(double radius){
		this.radius = radius;
	}

	public double GetRadius(){
		return this.radius;
	}
}
class CircleDemo{
	static void Main(string[] args){

		Console.WriteLine("Enter the radius : ");
		double radius = double.Parse(Console.ReadLine());

		// Object creation → default constructor call
		Circle circle1 = new Circle();
		Console.WriteLine("The radius of the circle : "+circle1.GetRadius());

		// Object creation -> parameterized constructor call
		Circle circle2 = new Circle();
		Console.WriteLine("The radius of the circle : "+circle2.GetRadius());


	}
}
