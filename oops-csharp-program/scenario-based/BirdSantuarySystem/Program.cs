using BirdSantuarySystem;
using System;
public class Program
{
    static void Main(string[] args)
    {
        Bird[] birds ={
            new Eagle("Eagle", "Brown", "Aquila chrysaetos", 5),
            new Sparrow("Sparrow", "Grey", "Passer domesticus", 2),
            new Duck("Duck", "White", "Anas platyrhynchos", 3),
            new Penguin("Penguin", "Black & White", "Aptenodytes forsteri", 6),
            new Seagull("Seagull", "White", "Larus argentatus", 4)
        };

        foreach(Bird bird in birds)
        {
            Console.WriteLine(bird.ToString());
            if(bird is IFlyable isFlayable && bird is ISwimmable IsSwimmable)
            {
                IsSwimmable.Swim();
                isFlayable.Fly();
            }
            else if(bird is ISwimmable swimmable)
            {
                swimmable.Swim();
            }
            else if(bird is IFlyable isFlyable)
            {
                isFlyable.Fly();
            }
        }
    }
}