using System;
class RemoveSpecificCharacter{
        static string RemoveCharacter(string str,char removeChar){
                string result="";

                for(int i=0;i<str.Length;i++){
                        if(str[i]!=removeChar){
                                result+=str[i];
                        }
                }
                return result;
        }

        static void Main(String[] args){
                Console.WriteLine("Enter a string:");
                string str=Console.ReadLine();

                Console.WriteLine("Enter character to remove:");
                char ch=Console.ReadLine()[0];

                string newStr=RemoveCharacter(str,ch);

                Console.WriteLine("ResultString : "+newStr);
        }
}

