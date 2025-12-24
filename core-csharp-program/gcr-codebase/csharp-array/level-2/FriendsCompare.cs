using System;
class FriendsCompare{
	static void Main(String[] args){

		// names of friends
		String[] names = {"Amar","Akbar","Anthony"};

		// create two arrays of size 3
		int[] age =new int[3];
		double[] height = new double[3];

		// input loop
		for(int i=0;i<3;i++){
			Console.WriteLine("Enter the age and height of "+names[i]);
			age[i] = int.Parse(Console.ReadLine());
			height[i] = double.Parse(Console.ReadLine());
		}

		// find youngest and tallest 

		String youngestPersonName = "Amar";
		int minAge = age[0];
		String tallestPersonName = "Amar";
		double maxHeight = height[0];

		for(int i=1;i<3;i++){

			// if condition for youngest person
			if(minAge > age[i]){
				minAge = age[i];
				youngestPersonName = names[i];
			}

			// condition for tallest person
			if(maxHeight < height[i]){
				maxHeight = height[i];
				tallestPersonName = names[i];
			}
		}

		// display the name of youngest and tallest person
		Console.WriteLine(youngestPersonName+" is the youngest person among three friends.");
		Console.WriteLine(tallestPersonName+" is the tallest person among three friends.");
	}
}
