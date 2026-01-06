using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSantuarySystem{
    public class Bird{

        protected string name;
        protected string color;
        protected string scientificName;
        protected int age;

        
        public Bird(string name,string color,string scientificName,int age){
            this.name = name;
            this.color = color;
            this.scientificName = scientificName;
            this.age = age;
        }


        public override string ToString()
        {
            return $"\nName             :     {name}\n" +
                   $"Color            :     {color}\n" +
                   $"ScientificName   :     {scientificName}\n" +
                   $"Age              :     {age}";
        }
    }
}
