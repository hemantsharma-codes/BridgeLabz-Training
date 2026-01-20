using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MultilevelUniversityCourseManagementSystem
{
    class ExamCourse : CourseType
    {
        public ExamCourse(string courseName) : base(courseName) { }

        public override void Evaluate()
        {
            Console.WriteLine($"{CourseName} evaluated by written exam.");
        }
    }

}
