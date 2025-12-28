using System;
class CreateSubstring{
	static string CreateSubstringUsingCharAt(string str,int firstIdx,int lastIdx){
		if(firstIdx < 0 || lastIdx >= str.Length || firstIdx > lastIdx){
			Console.WriteLine("Please enter the valid index.");
			return "";
		}

		string result = "";
		for(int i=firstIdx;i<=lastIdx;i++){
			result += str[i];
		}

		return result;
	}

	static void Main(String[] args){

		// take input of string
		Console.WriteLine("Please enter the string :");
		String str = Console.ReadLine();

		// take input for first and last index of substring
		Console.WriteLine("Please enter the first and last index of substring :");
		int firstIdx = int.Parse(Console.ReadLine());
		int lastIdx = int.Parse(Console.ReadLine());

		string subStrUsingCharAt = CreateSubstringUsingCharAt(str,firstIdx,lastIdx);

		string subStrUsingBuiltIn = str.Substring(firstIdx,lastIdx-firstIdx+1);

		// display results
		Console.WriteLine("Substring using CharAt() logic : "+subStrUsingCharAt);
		Console.WriteLine("Substring using Substring() built-in method : "+subStrUsingBuiltIn);
	}
}
