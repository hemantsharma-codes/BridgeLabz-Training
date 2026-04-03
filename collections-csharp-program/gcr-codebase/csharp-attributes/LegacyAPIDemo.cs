using System;

class LegacyAPIDemo
{
    static void Main(string[] args)
    {
#pragma warning disable CS0618
        OldFeature();
#pragma warning restore CS0618

        NewFeature();
    }

    [Obsolete("Use NewFeature instead")]
    static void OldFeature()
    {
        Console.WriteLine("Old feature executed");
    }

    static void NewFeature()
    {
        Console.WriteLine("New feature executed");
    }
}
