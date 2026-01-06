using System;
class Student
{
    // static: shared across all students
    public static string UniversityName;
    private static int totalStudents;

    // readonly: cannot be changed
    public readonly int RollNumber;

    // instance variables
    public string Name;
    public string Grade;

    // static constructor
    static Student()
    {
        UniversityName = "Global Tech University";
        totalStudents = 0;
    }

    // constructor using this
    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    // static method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // display student details
    public void Display()
    {
        Console.WriteLine("University : " + UniversityName);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Roll No    : " + RollNumber);
        Console.WriteLine("Grade      : " + Grade);
    }
}
class Program
{
    static void Main()
    {
        object s1 = new Student("Amit", 101, "A");
        object s2 = new Student("Neha", 102, "B");

        // is operator check before operations
        if (s1 is Student)
        {
            Student st = (Student)s1;
            st.Display();
        }

        Student.DisplayTotalStudents();
    }
}
