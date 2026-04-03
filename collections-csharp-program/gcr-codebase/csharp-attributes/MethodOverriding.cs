using System;
class Animal
{
    // Parent class method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // Overriding the parent method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class MethodOverriding
{
    static void Main(string[] args)
    {
        // Create object of Dog class
        Dog dog = new Dog();

        // Call overridden method
        dog.MakeSound();
    }
}

