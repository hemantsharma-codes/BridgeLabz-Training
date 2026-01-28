using System;
using System.Reflection;
class Student
{
    public int rollNumber = 101;
    public string studentName = "Hemant";

    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Student Name: " + studentName);
    }
}

class DynamicObjectCreationProgram
{
    static void Main(string[] args)
    {
        Type studentType = typeof(Student);

        object studentObject = Activator.CreateInstance(studentType);

        MethodInfo displayMethod = studentType.GetMethod("DisplayStudent");

        displayMethod.Invoke(studentObject, null);
    }
}

