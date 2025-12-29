using System;
class AnalyzeParagraph{
	static void Main(String[] args){

		InitializeApp();
	}

	static void InitializeApp(){
		
		Console.WriteLine("\n============================= Paragraph Analyzer =============================\n");
		
		Console.WriteLine("1.Count the number of words in the paragraph.");
		Console.WriteLine("2.Find and display the longest word.");
		Console.WriteLine("3.Replace all occurrences of a specific word with another word.");

		// take input
		Console.WriteLine("\nEnter the operation number what you want to perform :\n");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("\nEnter the Formatted Paragraph : \n");
		String paragraph = Console.ReadLine();

		// check edge cases
		if(paragraph.Length == 0){
			Console.WriteLine("Please enter a valid paragraph.");
			return;
		}

		switch(n){
			case 1:
				Console.WriteLine("Count the number of words in the paragraph : "+CountTotalWords(paragraph));
				break;
			case 2:
				Console.WriteLine("The longest word of the given string : "+FindLongestWord(paragraph));
				break;
			case 3:
				Console.WriteLine("Enter the word to replace from given paragraph : ");
				string replaceWord = Console.ReadLine();
				Console.WriteLine("Enter the word to replace with given word in paragraph : ");
				string givenWord = Console.ReadLine();
				Console.WriteLine("String after replacing all words : "+ReplaceAllOccurences(paragraph,replaceWord,givenWord));
				break;
			default :
				Console.WriteLine("Please enter the valid option :");
				break;
		}

	}
	static int CountTotalWords(string paragraph){

		int count = 0;
		for(int i=0;i<paragraph.Length;i++){
			char ch = paragraph[i];
			if(ch == ' '){
				count++;
			}
		}
		count++;
		return count;
	}
	static string FindLongestWord(string paragraph){
		string longestWord = "";
		string temp = "";

		for(int i=0;i<paragraph.Length;i++){
			char ch = paragraph[i];
			if(ch == ' '){
				if(longestWord.Length < temp.Length){
					longestWord = temp;
				}
				temp = "";
			}
			else{
				temp += ch;
			}
		}
		return longestWord.Length < temp.Length ? temp : longestWord;
	}
	static string ReplaceAllOccurences(string paragraph,string replaceWord,string givenWord){
		// string[] words = paragraph.Split(' ');

		int countWords = 0;
		for(int i=0;i<paragraph.Length;i++){
			char ch = paragraph[i];
			if(ch == ' '){
				countWords++;
			}
		}
		countWords++;
		
		// create string array to store words
		string[] words = new string[countWords];

		string temp = "";
		int idx = 0;
		for(int i=0;i<paragraph.Length;i++){
			char ch = paragraph[i];
			if(ch == ' '){
				words[idx] = temp;
				temp = "";
				idx++;
			}
			else{
				temp += ch;
			}
		}
		words[idx] = temp;

		String result = "";
		for(int i=0;i<words.Length;i++){
			if(words[i] == replaceWord){
				result += givenWord;
				if(i != words.Length-1){
					result += " ";
				}
			}
			else{
				result += words[i];
				if(i != words.Length-1){
					result += " ";
				}
			}
		}
		return result;
	}

}

