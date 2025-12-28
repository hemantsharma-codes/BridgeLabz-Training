using System;
class MostFrequentCharacter{
        static char FindMostFrequentCharacter(string str){
                int maxCount=0;
                char mostFrequentChar='\0';

                for(int i=0;i<str.Length;i++){
                        int count=1;

                        for(int j=i+1;j<str.Length;j++){
                                if(str[i]==str[j]){
                                        count++;
                                }
                        }

                        if(count>maxCount){
                                maxCount=count;
                                mostFrequentChar=str[i];
                        }
                }
                return mostFrequentChar;
        }

        static void Main(String[] args){
                Console.WriteLine("Enter a string:");
                string str=Console.ReadLine();

                char result=FindMostFrequentCharacter(str);

                Console.WriteLine("Most Frequent Character:"+result);
        }
}

