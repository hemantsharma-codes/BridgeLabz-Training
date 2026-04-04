using System;
class AnagramCheck{
        static bool CheckAnagram(string str1,string str2){

                // remove length mismatch
                if(str1.Length!=str2.Length){
                        return false;
                }

                int[] freq=new int[256];

                // count characters of first string
                for(int i=0;i<str1.Length;i++){
                        char ch=str1[i];

                        // convert uppercase to lowercase using ASCII
                        if(ch>='A'&&ch<='Z'){
                                ch=(char)(ch+32);
                        }
                        freq[ch]++;
                }

                // reduce count using second string
                for(int i=0;i<str2.Length;i++){
                        char ch=str2[i];

                        if(ch>='A'&&ch<='Z'){
                                ch=(char)(ch+32);
                        }
                        freq[ch]--;
                }

                // check frequency array
                for(int i=0;i<256;i++){
                        if(freq[i]!=0){
                                return false;
                        }
                }
                return true;
        }

        static void Main(String[] args){
                Console.WriteLine("Enter first string:");
                string str1=Console.ReadLine();

                Console.WriteLine("Enter second string:");
                string str2=Console.ReadLine();

                bool result=CheckAnagram(str1,str2);

                if(result){
                        Console.WriteLine("It's an Anagram Strings");
                }else{
                        Console.WriteLine("It's not an not Anagram Strings");
                }
        }
}

