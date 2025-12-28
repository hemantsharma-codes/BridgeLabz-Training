using System;
class FindLongestWord{
	static void FindLongestStringWord(string[] word){
		int idx = 0;
		int length = word[0].Length;

		if(word.Length == 1){
			Console.WriteLine("The Longest word in string is "+word[0]);
			return;
		}

		for(int i=1;i<word.Length;i++){
			if(word[i].Length > length){
				length = word[i].Length;
				idx = i;
			}
		}
		Console.WriteLine("The Longest word in string is : "+word[idx]);
	}

	static void Main(String[] args){
		Console.WriteLine("Enter a string : ");
		string str = Console.ReadLine();

		string[] word = str.Split(new char[]{' ', ','});

		FindLongestStringWord(word);
	}
}
