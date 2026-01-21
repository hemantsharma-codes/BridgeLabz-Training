using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.EduResults
{
    internal class Distric
    {
        private string _districName;
        private int _capcacityOfStudentArr;
        private Student[] _students;
        private int _currIdx;

        public Distric(string districName,int maxSize)
        {
            this._districName = districName;
            this._capcacityOfStudentArr = maxSize;
            _students = new Student[maxSize];
            _currIdx = 0;
        }

        // getter

        public string GetDistricName()
        {
            return this._districName;
        }
        public int GetCurrentIdx()
        {
            return this._currIdx;
        }
        public Student GetStudentAt(int index)
        {
            if (index < 0 || index >= _currIdx)
            {
                return null;
            }
            return _students[index];
        }


        // add students
        public void AddStudent()
        {
            if(_currIdx == _capcacityOfStudentArr)
            {
                Console.WriteLine("Students array is over");
            }
            Console.WriteLine("Enter the students count that you want to add");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            if(studentCount + _currIdx > _capcacityOfStudentArr)
            {
                Console.WriteLine("Please enter the less student count because memory is limited!");
                
            }
            else
            {
                for(int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine("Enter the marks of student");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student(marks);
                    _students[_currIdx++] = student;
                }

            }
        }

        // sort students
        public void SortStudents(int si, int ei)
        {
            if (si < ei)
            {
                int mid = si + (ei - si) / 2;
                SortStudents(si, mid);
                SortStudents(mid + 1, ei);
                Merge(si, mid, ei);
            }
        }
        public void Merge(int si, int mid, int ei)
        {
            Student[] temp = new Student[ei - si + 1];
            int k = 0; // for temp array
            int i = si; // left side
            int j = mid + 1; // right side


            while (i <= mid && j <= ei)
            {
                if (_students[i].GetStudentMarks() <= _students[j].GetStudentMarks())
                {
                    temp[k] = _students[i];
                    i++;
                }
                else
                {
                    temp[k] = _students[j];
                    j++;
                }
                k++;
            }

            while(i <= mid)
            {
                temp[k++] = _students[i++];
            }
            while(j <= ei)
            {
                temp[k++] = _students[j++];
            }


            for (k = 0, i = si; k < temp.Length; i++, k++)
            {
                _students[i] = temp[k];
            }
        }
        public void DisplayStudents()
        {
            for(int i = 0; i < _currIdx; i++)
            {
                Console.WriteLine(_students[i]);
            }
        }
    }
}
