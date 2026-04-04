using System;
class Operators{
	static void Main(String[] args){

		// Arithmetic Operators
		
		Console.WriteLine("Arithmetic operators : ");

		int arithOperand1 = 6;
		int arithOperand2 = 2;

		int add = arithOperand1+arithOperand2;
		int sub = arithOperand1-arithOperand2;
		int mult = arithOperand1*arithOperand2;
		int div = arithOperand1/arithOperand2;
		int mod = arithOperand1%arithOperand2;

		Console.WriteLine("Addition : "+add);
		Console.WriteLine("Subtraction : "+sub);
		Console.WriteLine("Multiplication :"+mult);
		Console.WriteLine("Division :"+div);
		Console.WriteLine("Modulus : "+mod);


		// Relational (Comparison) Operators
		
		Console.WriteLine("Relational Operators : ");
		
		int relOperand1 = 12;
		int relOperand2 = 4;

		Console.WriteLine("Equal to : "+(relOperand1 == relOperand2));
		Console.WriteLine("Not Equal to : "+(relOperand1 != relOperand2));
		Console.WriteLine("Greater than : "+(relOperand1 > relOperand2));
		Console.WriteLine("Less than :"+(relOperand1 < relOperand2));
		Console.WriteLine("Greater than eqaul to : "+(relOperand1 >= relOperand2));
		Console.WriteLine("Less than eqaul to : "+(relOperand1 <= relOperand2));

		// Logical Operators
		
		Console.WriteLine("Logical Operators : ");
		
		bool a = true;
		bool b = false;

		Console.WriteLine("Logical And : "+(a && b));
		Console.WriteLine("Logical Or : "+(a || b));
		Console.WriteLine("Logical Not : "+(!a));


		// Assignment Operators
		
		int assignOperand = 10;

		Console.WriteLine("assignOperand is : "+assignOperand);

		assignOperand += 10;
		Console.WriteLine("assignOperand is : "+assignOperand);

		assignOperand -= 10;
		Console.WriteLine("assignOperand is : "+assignOperand);

		assignOperand *= 2;
		Console.WriteLine("assignOperand is : "+assignOperand);



		// Unary Operators
		Console.WriteLine("Unary Operators : ");

		int unaryOperand = 10;

		Console.WriteLine("pre increment operator : "+(++unaryOperand));
		Console.WriteLine("post incremnt Operator : "+(unaryOperand++));
		Console.WriteLine("pre decrement operator : "+(--unaryOperand));

		// Ternary Operators

		Console.WriteLine("Ternary operator : ");
		
		int ternaryOperand1 = 10;
		int ternaryOperand2 = 20;

		int max = (ternaryOperand1 > ternaryOperand2) ? ternaryOperand1 : ternaryOperand2;
		Console.WriteLine(""+max);

	}
}

