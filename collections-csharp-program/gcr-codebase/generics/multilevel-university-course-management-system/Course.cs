using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MultilevelUniversityCourseManagementSystem
{
    class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        public List<T> GetCourses()
        {
            return courses;
        }
    }

}
