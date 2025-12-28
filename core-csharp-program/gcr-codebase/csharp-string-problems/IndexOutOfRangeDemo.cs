using System;
class IndexOutOfRangeDemo{
        static void GenerateIndexOutOfRangeException(){
                string text="BridgeLabz";
                Console.WriteLine(text[20]);
        }
        static void Main(String[] args){
                try{
                        GenerateIndexOutOfRangeException();
                }
                catch(IndexOutOfRangeException e){
                        Console.WriteLine("IndexOutOfRangeException occurred");
                        Console.WriteLine(e.Message);
                }
        }
}

