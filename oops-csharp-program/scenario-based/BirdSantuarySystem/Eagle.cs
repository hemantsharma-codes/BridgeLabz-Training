using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSantuarySystem
{
    public class Eagle:Bird,IFlyable
    {
        public Eagle(string name,string color,string scientificName,int age) : base(name, color, scientificName, age)
        {

        }
        public void Fly()
        {
            Console.WriteLine("Bird can fly.");
        }
    }
}
