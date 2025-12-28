using System;
class ReplaceWord{
        static string WordReplace(string sentence,string oldWord,string newWord){
                string result="";
                int i=0;

                while(i<sentence.Length){
                        int j=0;
                        int k=i;

                        // check word match
                        while(k<sentence.Length && j<oldWord.Length && sentence[k]==oldWord[j]){
                                k++;
                                j++;
                        }

                        // full word matched
                        if(j==oldWord.Length){
                                result+=newWord;
                                i=k;
                        }else{
                                result+=sentence[i];
                                i++;
                        }
                }
                return result;
        }

        static void Main(String[] args){
                Console.WriteLine("Enter a sentence:");
                string sentence=Console.ReadLine();

                Console.WriteLine("Enter word to replace:");
                string oldWord=Console.ReadLine();

                Console.WriteLine("Enter new word:");
                string newWord=Console.ReadLine();

                string newSentence=WordReplace(sentence,oldWord,newWord);

                Console.WriteLine("Updated Sentence : "+newSentence);
        }
}

