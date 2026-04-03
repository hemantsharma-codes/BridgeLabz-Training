using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSantuarySystem
{
    internal class Duck:Bird,ISwimmable
    {
        public Duck(string name,string color,string scientificName,int age) : base(name, color, scientificName, age)
        {

        }
        public void Swim()
        {
            Console.WriteLine("Bird can swim.");
        }
    }
}
