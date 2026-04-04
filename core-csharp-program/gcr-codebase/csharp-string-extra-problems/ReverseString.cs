using System;
class ReverseString{
        static string ReverseStringUsingLoop(string str){
                string result="";
                for(int i=str.Length-1;i>=0;i--){
                        result+=str[i];
                }
                return result;
        }
        static void Main(String[] args){
                Console.WriteLine("Enter a string:");
                string str=Console.ReadLine();

                string reversedStr=ReverseStringUsingLoop(str);

                Console.WriteLine("Reversed sring : "+reversedStr);
        }
}

