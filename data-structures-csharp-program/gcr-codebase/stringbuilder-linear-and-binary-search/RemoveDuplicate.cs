using System;
using System.Text;
class RemoveDuplicate{
	static string RemoveDuplicatesChars(string str){
		
		StringBuilder sb = new StringBuilder();

		for(int i=0;i<str.Length;i++){

			char curr = str[i];
			bool isDuplicate = false;

			for(int j=0;j<sb.Length;j++){
				if(sb[j] == curr){
					isDuplicate = true;
					break;
				}
			}
			if(!isDuplicate){
				sb.Append(curr);
			}
		}
		return sb.ToString();
	}
	static void Main(string[] args){

		Console.WriteLine("Enter the string :");
		string str = Console.ReadLine();

		string output = RemoveDuplicatesChars(str);

		Console.WriteLine("The Old string is : "+str);
		Console.WriteLine("The string after removing duplicates : "+output);
	}
}
