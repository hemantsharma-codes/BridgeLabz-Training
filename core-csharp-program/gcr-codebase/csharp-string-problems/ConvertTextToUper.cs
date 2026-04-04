using System;
class ConverTextToUper{
	static string ConvertToUpperUsingAscii(string str){
		string result = "";
		for(int i=0;i<str.Length;i++){
			int asciiValue = (int)str[i];
			if(asciiValue >= 97 && asciiValue <= 122){
				asciiValue -= 32;
			}
			result += Convert.ToChar(asciiValue);
		}
		return result;
	}
	static void Main(String [] args){
		// take an input string
		Console.WriteLine("Please enter a string :");
		string str = Console.ReadLine();

		// method calling
		string asciiStr = ConvertToUpperUsingAscii(str);

		// conversion of string using ToUpper() built-in funtion
		string builtInStr = str.ToUpper();

		// diplay results
		Console.WriteLine("Conversion of string using ascii method : "+asciiStr);
		Console.WriteLine("Conversion of string using ToUper() built-in method : "+builtInStr);

	}
}
