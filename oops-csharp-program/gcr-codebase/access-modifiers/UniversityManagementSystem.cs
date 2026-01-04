using System;
class Student{
    public int rollNumber;
    protected string name;
    private double cgpa;

    // Constructor
    public Student(int rollNumber, string name, double cgpa){
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }

    // Public method to get CGPA
    public double GetCGPA(){
        return cgpa;
    }

    // Public method to set CGPA
    public void SetCGPA(double cgpa){
        this.cgpa = cgpa;
    }

    // Display basic student details
    public void DisplayStudent(){
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("CGPA        : " + cgpa);
    }
}

// Subclass to demonstrate protected member
class PostgraduateStudent : Student{
    private string specialization;

    public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
        : base(rollNumber, name, cgpa){
        this.specialization = specialization;
    }

    public void DisplayPGStudent(){
        Console.WriteLine("Roll Number     : " + rollNumber); // public
        Console.WriteLine("Name            : " + name);       // protected (accessible)
        Console.WriteLine("Specialization  : " + specialization);
        Console.WriteLine("CGPA            : " + GetCGPA());  // private accessed via method
    }
}

class UniversityManagementSystem{
    static void Main(string[] args){
        Student s1 = new Student(101, "Hemant Sharma", 8.6);

        Console.WriteLine("Student Details:");
        s1.DisplayStudent();

        // Modify CGPA using public method
        s1.SetCGPA(8.9);
        Console.WriteLine("\nAfter CGPA Update:");
        Console.WriteLine("Updated CGPA : " + s1.GetCGPA());

        Console.WriteLine("\nPostgraduate Student Details:");
        PostgraduateStudent pg = new PostgraduateStudent(201, "Amit Kumar", 9.1, "Computer Science");
        pg.DisplayPGStudent();
    }
}

