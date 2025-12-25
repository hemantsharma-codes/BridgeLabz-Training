using System;
class FriendsComparison{
        static int FindYoungestFriend(int[] ages){
		int minAgeIndex = 0;

                for (int i=1;i< ages.Length;i++){
			if (ages[i] < ages[minAgeIndex]){
				minAgeIndex = i;
			}
		}
                return minAgeIndex;
	}

	static int FindTallestFriend(double[] heights){
		int maxHeightIndex = 0;
		for (int i=1;i<heights.Length;i++){
			if (heights[i] > heights[maxHeightIndex]){
				maxHeightIndex = i;
			}
		}
                return maxHeightIndex;
	}

	static void Main(string[] args){
		// name of friends
		string[] names = { "Amar", "Akbar", "Anthony" };

		// create arrays for age and height
	        int[] ages = new int[3];
                double[] heights = new double[3];

                // take user input
		for (int i=0;i< 3;i++){
			Console.WriteLine("Enter age of "+names[i]+" :");
			ages[i] = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter height of "+names[i]+" (in cm):");
                        heights[i] = double.Parse(Console.ReadLine());

                        Console.WriteLine();
		}

		// method calls
                int youngestIndex = FindYoungestFriend(ages);
                int tallestIndex = FindTallestFriend(heights);

                // display results
                Console.WriteLine("Youngest friend is: "+names[youngestIndex]);
                Console.WriteLine("Tallest friend is: "+names[tallestIndex]);
    }
}

