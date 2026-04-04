using System;
class IndexOutOfRangeForArray{
        static void GenerateArrayIndexOutOfRangeException(){
                int[] numbers={10,20,30};
                Console.WriteLine(numbers[5]);
        }
        static void Main(String[] args){
                try{
                        GenerateArrayIndexOutOfRangeException();
                }
                catch(IndexOutOfRangeException e){
                        Console.WriteLine("IndexOutOfRangeException occurred");
                        Console.WriteLine(e.Message);
                }
        }
}

