
namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.EduResults
{
    internal class EducationBoard : IEducationalBoard
    {
        private Distric[] _districs;
        private int _currIdx;

        private Student[] _mergeStudents;
        private int _mergeIdx;
        private int _mergeCapacity = 10;

        public EducationBoard(int size)
        {
            _districs = new Distric[size];
            _mergeStudents = new Student[_mergeCapacity];
        }

        public void AddDistric()
        {
            Console.Write("Enter district name: ");
            string name = Console.ReadLine();

            Console.Write("Enter max students: ");
            int size = Convert.ToInt32(Console.ReadLine());

            _districs[_currIdx++] = new Distric(name, size);
            Console.WriteLine("District added successfully.");
        }

        public void AddStudent()
        {
            Console.Write("Enter district name: ");
            string name = Console.ReadLine().Trim().ToLower();

            for (int i = 0; i < _currIdx; i++)
            {
                if (_districs[i].GetDistricName().ToLower() == name)
                {
                    _districs[i].AddStudent();
                    _districs[i].SortStudents(0, _districs[i].GetCurrentIdx() - 1);
                    return;
                }
            }

            Console.WriteLine("District not found.");
        }

        public void DisplayAllDistric()
        {
            for (int i = 0; i < _currIdx; i++)
            {
                Console.WriteLine($"\n--- {_districs[i].GetDistricName()} ---");
                _districs[i].DisplayStudents();
            }
        }

        private void ResizeMergeArray()
        {
            _mergeCapacity *= 2;
            Student[] newArr = new Student[_mergeCapacity];

            for (int i = 0; i < _mergeIdx; i++)
                newArr[i] = _mergeStudents[i];

            _mergeStudents = newArr;
        }

        public void DisplayRankWise()
        {
            _mergeIdx = 0;
            int[] idx = new int[_currIdx];
            bool remaining = true;

            while (remaining)
            {
                remaining = false;
                Student min = null;
                int minD = -1;

                for (int d = 0; d < _currIdx; d++)
                {
                    if (idx[d] < _districs[d].GetCurrentIdx())
                    {
                        remaining = true;
                        Student curr = _districs[d].GetStudentAt(idx[d]);

                        if (min == null || curr.GetStudentMarks() < min.GetStudentMarks())
                        {
                            min = curr;
                            minD = d;
                        }
                    }
                }

                if (min != null)
                {
                    if (_mergeIdx == _mergeCapacity)
                        ResizeMergeArray();

                    _mergeStudents[_mergeIdx++] = min;
                    idx[minD]++;
                }
            }

            Console.WriteLine("\n===== STATE WISE RANK LIST =====");
            for (int i = _mergeIdx - 1; i >= 0; i--)
                Console.WriteLine(_mergeStudents[i]);
        }
    }
}
