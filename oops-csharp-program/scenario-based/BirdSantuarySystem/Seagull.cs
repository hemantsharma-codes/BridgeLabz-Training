using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSantuarySystem
{
    public class Seagull :Bird,IFlyable,ISwimmable{

        public Seagull(string name,string color,string scientificName,int age) : base(name, color, scientificName, age)
        {

        }
        public void Swim()
        {
            Console.Write("Bird can Swim.");
        }
        public void Fly()
        {
            Console.Write("And Fly.");
        }
    }
}
