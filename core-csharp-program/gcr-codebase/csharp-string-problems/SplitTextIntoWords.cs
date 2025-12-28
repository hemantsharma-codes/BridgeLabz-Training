using System;
class SplitTextIntoWords{
	static string[,] SplitText(string str){
		// calculate size of 2D array
		
		int cnt = 0;
		for(int i=0;i<str.Length;i++){
			if(str[i] == ' '){
				cnt++;
			}
		}

		string[,] result = new string[cnt+1,2];

		String temp = "";
		int idx = 0;
		for(int i=0;i<str.Length;i++){
			if(str[i] == ' '){
				result[idx,0] = temp;
				temp = "";
				idx++;
			}
			else{
				temp += str[i];
			}
		}
		result[idx,0] = temp;

		return result;

	}
	static void CalculateLength(string[,] words){

		for(int i=0;i<words.GetLength(0);i++){
			words[i,1] = words[i,0].Length.ToString();
		}
	}
	static void Main(String[] args){

		// take an input string
		Console.WriteLine("Please enter the string :");
		String str = Console.ReadLine();

		string[,] words = SplitText(str);

		// calculate length of each word
		CalculateLength(words);

		// display result
		Console.WriteLine("Length of each word :");
		for(int i=0;i<words.GetLength(0);i++){
			Console.WriteLine(words[i,0]+"\t"+words[i,1]);
		}

	}
}

