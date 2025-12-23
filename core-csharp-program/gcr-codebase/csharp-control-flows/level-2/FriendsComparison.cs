using System;
class FriendsComparsion{
	static void Main(String[] args){

		Console.WriteLine("Enter the age and the height of Amar :");
		int ageAmar = int.Parse(Console.ReadLine());
		double heightAmar = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the age and the height of Akbar :");
		int ageAkbar = int.Parse(Console.ReadLine());
		double heightAkbar = double.Parse(Console.ReadLine());

		Console.WriteLine("Enter the age and the height of Anthony :");
		int ageAnthony = int.Parse(Console.ReadLine());
		double heightAnthony = double.Parse(Console.ReadLine());

		// finding the youngest among of three
		if(ageAmar > ageAkbar && ageAmar > ageAnthony){
			Console.WriteLine("Amar is the youngest.");
		}
		else if(ageAkbar > ageAmar && ageAkbar > ageAnthony){
			Console.WriteLine("Akbar is the youngest.");
		}
		else{
			Console.WriteLine("Anthony is the youngest.");
		}

		// finding the tallest among of three
		
		if(heightAmar > heightAkbar && heightAmar > heightAnthony){
                        Console.WriteLine("Amar is the tallest.");
                }
                else if(heightAkbar > heightAmar && heightAkbar > heightAnthony){
                        Console.WriteLine("Akbar is the tallest.");
                }
                else{
                        Console.WriteLine("Anthony is the tallest.");
                }
	}
}

