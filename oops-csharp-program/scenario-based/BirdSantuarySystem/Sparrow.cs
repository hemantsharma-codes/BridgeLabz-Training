using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSantuarySystem
{
    public class Sparrow : Bird,IFlyable
    {
        public Sparrow(string name,string color,string scientificName,int age):base(name,color,scientificName,age)
        {

        }
        public void Fly()
        {
            Console.WriteLine("Bird can fly.");
        }
    }
}
