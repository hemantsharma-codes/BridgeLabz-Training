using System;
class SideOfSq{
	static void Main(String[] args){

		Console.WriteLine("Enter the perimeter of sqaure :");
		float perimeter = float.Parse(Console.ReadLine());

		float sideSq = perimeter/4;

		Console.WriteLine("The length of the side is "+sideSq+" whose perimeter is "+perimeter);
	}
}

