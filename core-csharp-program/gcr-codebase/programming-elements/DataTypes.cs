using System;
class DataTypes{
	static void Main(String[] args){
		
		// Integer Types

		byte myByteNum = 25;
		int myNum = 5;
		short myShortVal = 1200;
		long myLongVal = 98379329L;


		// Floating point types

		float myFloatNum = 12.5f;
		double myDoubleNum = 5.99D;
		decimal myDecimalNum = 9999.99m;

		// Character and Boolean

		char myLetter = 'D';
		bool myBool = true;


		// Displays values

		Console.WriteLine("Byte value : "+myByteNum);
		Console.WriteLine("Int value : "+myNum);
		Console.WriteLine("Short value : "+myShortVal);
		Console.WriteLine("Long value : "+myLongVal);
		Console.WriteLine("Float value : "+myFloatNum);
		Console.WriteLine("Double value : "+myDoubleNum);
		Console.WriteLine("Decimal value : "+myDecimalNum);
		Console.WriteLine("Char value : "+myLetter);
		Console.WriteLine("Bool value : "+myBool);


		// Types Casting - when you assign of one data type to another type
		
		// implicit casting - converting a smaller type to a larger type size

		Console.WriteLine("implicit casting : ");
		double doubleVal = myNum;
		Console.WriteLine("Value before implicit casting : "+myNum);
		Console.WriteLine("Value after implicit casting : "+doubleVal);

		// explicit casting - converting a larger type to a smaller size type
		
		Console.WriteLine("explicit casting : ");
		double myDouble = 9.78;
		int myInt = (int) myDouble;
		Console.WriteLine("Value before explicit type casting : "+myDouble);
		Console.WriteLine("Value after explicit type casting : "+myInt);
	}

}


