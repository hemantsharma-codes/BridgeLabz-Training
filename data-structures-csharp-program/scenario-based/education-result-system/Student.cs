using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.EduResults
{
    internal class Student
    {
        private int _studentsCount = 0;
        private int _studentId;
        private int _studentMarks;

        // constructor
        public Student(int studentMarks)
        {

            this._studentId = ++_studentsCount;
            this._studentMarks = studentMarks;
        }

        // getter
        public int GetStudentMarks()
        {
            return this._studentMarks;
        }

        // ToString() method overriding
        public override string ToString()
        {
            return $"\nStudent Id : {_studentId}\nstudent Marks : {_studentMarks}";
        }
    }
}
