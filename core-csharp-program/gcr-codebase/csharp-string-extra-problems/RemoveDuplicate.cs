using System;
class RemoveDuplicate{
	static string DuplicatesRemove(string str){
		string result = "";

		for(int i=0;i<str.Length;i++){
			bool flag = true;
			for(int j=0;j<str.Length;j++){
				if(str[i] == str[j] && i != j){
					flag = false;
				}
			}
			if(flag == true){
				result += str[i];
			}
		}
		return result;
	}
	static void Main(String[] args){
		Console.WriteLine("Enter a string : ");
		string str = Console.ReadLine();

		// method calling
		string result = DuplicatesRemove(str);

		Console.WriteLine("Old string is : "+str);
		Console.WriteLine("Modified string after removing all duplicate characters : "+result);
	}
}
