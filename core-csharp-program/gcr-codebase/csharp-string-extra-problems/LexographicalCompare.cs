using System;
class LexicographicalCompare{
        static int CompareStringsLexicographically(string str1,string str2){
                int i=0;

                while(i<str1.Length && i<str2.Length){
                        if(str1[i]!=str2[i]){
                                return str1[i]-str2[i];
                        }
                        i++;
                }

                // if all previous characters are equal
                return str1.Length-str2.Length;
        }

        static void Main(String[] args){
                Console.WriteLine("Enter first string:");
                string s1=Console.ReadLine();

                Console.WriteLine("Enter second string:");
                string s2=Console.ReadLine();

                int result=CompareStringsLexicographically(s1,s2);

                if(result==0){
                        Console.WriteLine("Both strings are equal");
                }else if(result<0){
                        Console.WriteLine(s1+" comes before "+s2+" in lexicographical order");
                }else{
                        Console.WriteLine(s2+" comes before "+s1+" in lexicographical order");
                }
        }
}

