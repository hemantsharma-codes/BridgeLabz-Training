using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MultilevelUniversityCourseManagementSystem
{
    abstract class CourseType
    {
        public string CourseName { get; set; }

        public CourseType(string courseName)
        {
            CourseName = courseName;
        }

        public abstract void Evaluate();
    }

}
