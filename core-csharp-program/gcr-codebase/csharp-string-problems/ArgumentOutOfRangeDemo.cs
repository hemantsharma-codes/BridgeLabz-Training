using System;
class ArgumentOutOfRangeDemo{
        static void GenerateArgumentOutOfRangeException(){
                string text="BridgeLabz";
                Console.WriteLine(text.Substring(10,5));
        }
        static void Main(String[] args){
                try{
                        GenerateArgumentOutOfRangeException();
                }
                catch(ArgumentOutOfRangeException e){
                        Console.WriteLine("ArgumentOutOfRangeException occurred");
                        Console.WriteLine(e.Message);
                }
        }
}

