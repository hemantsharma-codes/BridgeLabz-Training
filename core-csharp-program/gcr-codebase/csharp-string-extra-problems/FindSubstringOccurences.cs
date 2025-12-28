using System;
class FindSubstringOccurences{
	static int FindOccurences(string str,string subString){
		int count = 0;
		for(int i=0;i<=str.Length-subString.Length;i++){
			int j=0;
			while(j < subString.Length && str[i+j] == subString[j]){
				j++;
			}
			if(j == subString.Length){
				count++;
			}
		}
		return count;
	}
	static void Main(String[] args){
		
		Console.WriteLine("Enter a string : ");
		string str = Console.ReadLine();

		Console.WriteLine("Enter a substring : ");
		string subString = Console.ReadLine();

		int count = FindOccurences(str,subString);

		Console.WriteLine("The total no of count is "+count+ " of substring "+subString+" in string "+str);
	}
}
