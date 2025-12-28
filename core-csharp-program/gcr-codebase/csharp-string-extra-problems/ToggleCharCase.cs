using System;
class ToggleCharCase{
	static void Main(String[] args){
		Console.WriteLine("Enter a string : ");
		string str = Console.ReadLine();

		// conversion of characters
		string result = "";
		for(int i=0;i<str.Length;i++){
			char ch = str[i];

			if(ch >= 'A' && ch <= 'Z'){
				int asciiValue = (int)ch;
				asciiValue += 32;
				result += Convert.ToChar(asciiValue);
			}
			else if(ch >= 'a' && ch <= 'z'){
				int asciiValue = (int)ch;
				asciiValue -= 32;
				result += Convert.ToChar(asciiValue);
			}
			else{
				result += str[i];
			}
		}

		Console.WriteLine("The toggle string is : "+result);
	}
}

