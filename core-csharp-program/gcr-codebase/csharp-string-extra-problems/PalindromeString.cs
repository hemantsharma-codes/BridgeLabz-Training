using System;
class PalindromeString{
        static bool CheckPalindromeString(string str){
                int left=0;
                int right=str.Length-1;

                while(left<=right){
                        if(str[left]!=str[right]){
                                return false;
                        }
                        left++;
                        right--;
                }
                return true;
        }
        static void Main(String[] args){
                Console.WriteLine("Enter a string:");
                string str=Console.ReadLine();

                bool isPalindrome=CheckPalindromeString(str);

                if(isPalindrome){
                        Console.WriteLine("Palindrome String");
                }else{
                        Console.WriteLine("It's not a Palindrome String");
                }
        }
}

