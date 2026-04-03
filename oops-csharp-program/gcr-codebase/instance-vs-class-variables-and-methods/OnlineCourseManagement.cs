using System;
class Course{
    // Instance variables
    private string courseName;
    private int duration;      // in months
    private double fee;

    // Class variable (shared by all courses)
    private static string instituteName = "ABC Institute";

    // Parameterized constructor
    public Course(string courseName, int duration, double fee){
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails(){
        Console.WriteLine("Course Name     : " + courseName);
        Console.WriteLine("Duration        : " + duration + " months");
        Console.WriteLine("Fee             : " + fee);
        Console.WriteLine("Institute Name  : " + instituteName);
    }

    // Class (static) method
    public static void UpdateInstituteName(string newInstituteName){
        instituteName = newInstituteName;
    }
}
class OnlineCourseManagement{
    static void Main(string[] args){
        // Create course objects
        Course c1 = new Course("Full Stack Development", 6, 45000);
        Course c2 = new Course("Data Science", 8, 60000);

        Console.WriteLine("Course Details (Before Update):");
        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();

        // Update institute name for all courses
        Console.Write("\nEnter New Institute Name: ");
        string newName = Console.ReadLine();
        Course.UpdateInstituteName(newName);

        Console.WriteLine("\nCourse Details (After Update):");
        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();
    }
}

