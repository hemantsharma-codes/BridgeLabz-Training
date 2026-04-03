using System;
using System.Reflection;
class Employee
{
    public int id;
    private string name;

    public Employee() { }

    public Employee(int empId)
    {
        id = empId;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Employee Details");
    }

    private void SecretMethod()
    {
        Console.WriteLine("This is private");
    }
}

class ClassInformationProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type classType = Type.GetType(className);

        if (classType == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in classType.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in classType.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo constructor in classType.GetConstructors())
        {
            Console.WriteLine(constructor.Name);
        }
    }
}

