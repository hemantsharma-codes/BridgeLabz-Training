using System;
class CompareTwoStrings{
	static bool Compare2String(string str1,string str2){

		if(str1.Length != str2.Length){
			return false;
		}
		int idx1 = 0;
		int idx2 = 0;

		while(idx1 < str1.Length || idx2 < str2.Length){
			if(str1[idx1] != str2[idx2]){
				return false;
			}
			idx1++;
			idx2++;
		}
		return true;
	}

	static void Main(string[] args){

		// take input of two strings
		Console.WriteLine("Please enter the first string :");
		string str1 = Console.ReadLine();
		Console.WriteLine("Please enter the second string :");
		string str2 = Console.ReadLine();

		// compare using charAt and call method
		bool charAtComparison = Compare2String(str1,str2);

		// compare using built-in Equals()
		bool equalsComparison = str1.Equals(str2);

		// Display results
		Console.WriteLine("Comparison using CharAt() logic : "+charAtComparison);
		Console.WriteLine("Comparison using Equals() built-in method : "+equalsComparison);

	
	}
}

