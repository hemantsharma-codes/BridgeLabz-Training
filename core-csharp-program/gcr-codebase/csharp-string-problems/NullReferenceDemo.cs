using System;
class NullReferenceDemo{
        static void ShowNullReferenceException(){
                string name=null;
                Console.WriteLine(name.Length);
        }
        static void Main(String[] args){
                try{
                        ShowNullReferenceException();
                }
                catch(NullReferenceException e){
                        Console.WriteLine("NullReferenceException occurred");
                        Console.WriteLine(e.Message);
                }
        }
}

