using System;
class CountVowelsConsonants{
        static void CountVowelsAndConsonants(string str){
                int vowelCount=0;
                int consonantCount=0;

                for(int i=0;i<str.Length;i++){
                        char ch=str[i];

                        // convert uppercase to lowercase using ASCII
                        if(ch>='A' && ch<='Z'){
                                ch=(char)(ch+32);
                        }

                        // check for alphabets
                        if(ch>='a' && ch<='z'){
                                if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'){
                                        vowelCount++;
                                }else{
                                        consonantCount++;
                                }
                        }
                }

                Console.WriteLine("Vowels:"+vowelCount);
                Console.WriteLine("Consonants:"+consonantCount);
        }

        static void Main(String[] args){
                Console.WriteLine("Enter a string:");
                string str=Console.ReadLine();

                CountVowelsAndConsonants(str);
        }
}

