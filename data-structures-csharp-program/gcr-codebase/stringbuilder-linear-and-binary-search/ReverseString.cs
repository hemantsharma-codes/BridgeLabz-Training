using System;
using System.Text;
class ReverseString{
	static string StringReverseMethod(string str){
		
		StringBuilder sb = new StringBuilder();

		for(int i=str.Length-1;i>=0;i--){
			sb.Append(str[i]);
		}

		return sb.ToString();
	}
	static void Main(string[] args){

		// take input string
		Console.WriteLine("Enter the String :");
		string str = Console.ReadLine();

		string reverseString = StringReverseMethod(str);
		Console.WriteLine("The Original string is : "+str+"\n The Reverse string is : "+reverseString);

	}
}
