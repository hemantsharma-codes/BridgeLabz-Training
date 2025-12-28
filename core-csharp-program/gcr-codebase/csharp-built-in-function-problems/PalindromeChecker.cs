using System;
class PalindromeChecker{
        static string TakeInput(){
                Console.WriteLine("Enter a string:");
                return Console.ReadLine();
        }

        static bool CheckPalindrome(string str){
                int left=0;
                int right=str.Length-1;

                while(left<right){

                        char chLeft=str[left];
                        char chRight=str[right];

                        // convert uppercase to lowercase using ASCII
                        if(chLeft>='A'&&chLeft<='Z'){
                                chLeft=(char)(chLeft+32);
                        }
                        if(chRight>='A'&&chRight<='Z'){
                                chRight=(char)(chRight+32);
                        }

                        if(chLeft!=chRight){
                                return false;
                        }
                        left++;
                        right--;
                }
                return true;
        }

        static void DisplayResult(bool result){
                if(result){
                        Console.WriteLine("Palindrome String");
                }else{
                        Console.WriteLine("Not Palindrome String");
                }
        }

        static void Main(String[] args){
                string str=TakeInput();
                bool result=CheckPalindrome(str);
                DisplayResult(result);
        }
}

