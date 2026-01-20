using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MultilevelUniversityCourseManagementSystem
{
    class Menu
    {
        private Course<ExamCourse> examCourses = new Course<ExamCourse>();
        private Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- University Course Management ---");
                Console.WriteLine("1. Add Exam Course");
                Console.WriteLine("2. Add Assignment Course");
                Console.WriteLine("3. Display All Courses");
                Console.WriteLine("0. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddExamCourse();
                        break;
                    case 2:
                        AddAssignmentCourse();
                        break;
                    case 3:
                        DisplayAllCourses();
                        break;
                }

            } while (choice != 0);
        }

        private void AddExamCourse()
        {
            Console.Write("Enter exam course name: ");
            string name = Console.ReadLine();
            examCourses.AddCourse(new ExamCourse(name));
        }

        private void AddAssignmentCourse()
        {
            Console.Write("Enter assignment course name: ");
            string name = Console.ReadLine();
            assignmentCourses.AddCourse(new AssignmentCourse(name));
        }

        // 🔹 Covariance used here
        private void DisplayCourses(IEnumerable<CourseType> courses)
        {
            foreach (var course in courses)
            {
                course.Evaluate();
            }
        }

        private void DisplayAllCourses()
        {
            Console.WriteLine("\n--- Exam Courses ---");
            DisplayCourses(examCourses.GetCourses());

            Console.WriteLine("\n--- Assignment Courses ---");
            DisplayCourses(assignmentCourses.GetCourses());
        }
    }

}
