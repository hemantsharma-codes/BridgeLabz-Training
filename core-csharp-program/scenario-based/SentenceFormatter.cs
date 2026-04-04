using System;
class SentenceFormatter{
	static bool IsSpecial(char[] specialCharacters,char ch){

		for(int i=0;i<4;i++){
			if(specialCharacters[i] == ch){
				return true;
			}
		}
		return false;
	}
	static string FormatteString(string paragraph){
		if(paragraph == null || paragraph.Length == 0){
			return "";
		}

		char[] specialCharacters = {'.',',','!','?'};
		bool capitalizeNext = true;
		string result = "";

		for(int i=0;i<paragraph.Length;i++){
			char ch = paragraph[i];

			// skip extra spaces
			if(ch == ' ' && result.Length > 0 && result[result.Length-1] == ' '){
				continue;
			}

			if(IsSpecial(specialCharacters,ch)){
				result += ch;

				// add space if next char is not space
				if(i+1 < paragraph.Length && paragraph[i+1] != ' '){
					result += " ";
				}
				capitalizeNext = true;
			}
			else if(ch == ' '){
				result += ch;
					
			}
			else{
				// capitalize if needed
				if(capitalizeNext && ch >= 'a' && ch <= 'z'){
					result += (char)(ch-32);
					capitalizeNext = false;
				}
				else{
					result += ch;
					capitalizeNext = false;
				}
			}
		}
		return result;
	}
	static void Main(String[] args){

		//=====================================*****Sentence Formatter*****================================================//
		
		// take a input paragraph
		Console.WriteLine("Enter a string : ");
		string paragraph = Console.ReadLine();

		// method calling
		string result = FormatteString(paragraph);

		// display result
		Console.WriteLine("Old string :"+paragraph);
		Console.WriteLine("New string :"+result);
	}
}
