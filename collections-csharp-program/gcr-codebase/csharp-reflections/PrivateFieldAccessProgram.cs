using System;
using System.Reflection;

class Person
{
    private int age = 18;
}

class PrivateFieldAccessProgram
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide age value");
            return;
        }

        int newAge = int.Parse(args[0]);

        Person personObject = new Person();
        Type personType = typeof(Person);

        FieldInfo ageField = personType.GetField(
            "age",
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        ageField.SetValue(personObject, newAge);

        int updatedAge = (int)ageField.GetValue(personObject);

        Console.WriteLine("Updated Age: " + updatedAge);
    }
}

