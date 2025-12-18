using System;

public class CylinderVolume
{
    public static void Main(string[] args)
    {
        Console.Write("Enter radius of the cylinder: ");
        float rad = float.Parse(Console.ReadLine());

        Console.Write("Enter height of the cylinder: ");
        int height = int.Parse(Console.ReadLine());

        float volume = 3.14f * rad * rad * height;

        Console.WriteLine("Volume of the cylinder: " + volume);
    }
}

