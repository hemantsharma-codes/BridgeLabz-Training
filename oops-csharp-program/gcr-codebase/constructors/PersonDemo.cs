using System;
class Person{
    private string name;
    private int age;

    // Public properties (to access private data)
    public string Name(){    
        return this.name;
    }

    public int Age(){
        return this.age;
    }

    // Normal constructor
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person p){
        name = p.name;
        age = p.age;
    }
}

class PersonDemo{
    static void Main(string[] args){
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        // Original object
        Person p1 = new Person(name,age);
        // Copied object
        Person p2 = new Person(p1);

        Console.WriteLine("\nOriginal Person:");
        Console.WriteLine(p1.Name()+" "+p1.Age());

        Console.WriteLine("Copied Person:");
        Console.WriteLine(p2.Name()+" "+p2.Age());
    }
}

