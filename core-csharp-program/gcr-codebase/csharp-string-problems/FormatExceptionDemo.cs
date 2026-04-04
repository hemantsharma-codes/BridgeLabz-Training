using System;
class FormatExceptionDemo{
        static void GenerateFormatException(){
                string value="abc";
                int number=int.Parse(value);
                Console.WriteLine(number);
        }
        static void Main(String[] args){
                try{
                        GenerateFormatException();
                }
                catch(FormatException e){
                        Console.WriteLine("FormatException occurred");
                        Console.WriteLine(e.Message);
                }
        }
}

