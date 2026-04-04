using System;
class ConvertTextToLower{
	static string ToLowerUsingAscii(string str){

		string result = "";
		for(int i=0;i<str.Length;i++){
			int asciiValue = (int)str[i];

			if(asciiValue >= 65 && asciiValue <= 91){
				asciiValue += 32;
			}
			result += Convert.ToChar(asciiValue);
		}
		return result;
	}
	static void Main(string[] args){

		// take an input string
		Console.WriteLine("Please enter the string :");
		string str = Console.ReadLine();

		// method call
		string asciiString = ToLowerUsingAscii(str);

		// conver string using built-in ToLower()
		string strUsingBuiltin = str.ToLower();

		// display the both results
		Console.WriteLine("Conversion of string using ascii logic : "+asciiString);
		Console.WriteLine("Conversion of string using ToLower() method : "+strUsingBuiltin);
	}
}
