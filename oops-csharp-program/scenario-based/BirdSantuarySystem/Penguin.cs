using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSantuarySystem
{
    public class Penguin:Bird,ISwimmable
    {
        public Penguin(string name,string color,string scientificName,int age):base(name,color,scientificName,age)
        {

        }
        public void Swim()
        {
            Console.WriteLine("Bird can swim");
        }
    }
}
