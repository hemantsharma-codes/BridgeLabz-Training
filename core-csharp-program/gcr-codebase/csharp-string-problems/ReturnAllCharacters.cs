using System;
class ReturnAllCharacters{
    static char[] GetCharWithoutUsingToCharArr(string str){

        char[] result = new char[str.Length];
        for(int i=0;i<str.Length;i++){ 
		result[i] = str[i];
	}

        return result;
    }
    static void Main(string[] args){
        Console.WriteLine("Enter the input string:");
        string str = Console.ReadLine();

        char[] customArray = GetCharWithoutUsingToCharArr(str);
        char[] builtInArray = str.ToCharArray();

        Console.WriteLine("Characters without ToCharArray():");
        foreach(char ch in customArray){
		Console.Write(ch+" ");
	}

        Console.WriteLine("\nCharacters using ToCharArray():");
        foreach(char ch in builtInArray){
		Console.Write(ch+" ");
	}
    }
}

