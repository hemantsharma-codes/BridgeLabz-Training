internal class StudentLinkedList
{
        private StudentNode head;

        public void AddAtBeginning(int rollNo, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        public void AddAtEnd(int rollNo, string name, int age, char grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void AddAtPosition(int position, int rollNo, string name, int age, char grade)
        {
            if (position <= 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }

            StudentNode temp = head;
            int count = 1;

            while (temp != null && count < position - 1)
            {
                temp = temp.Next;
                count++;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.RollNo == rollNo)
            {
                head = head.Next;
                Console.WriteLine("Student record deleted.");
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null && temp.Next.RollNo != rollNo)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted.");
        }

        public void SearchByRollNo(int rollNo)
        {
            StudentNode temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    DisplayStudent(temp);
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        public void UpdateGrade(int rollNo, char newGrade)
        {
            StudentNode temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                DisplayStudent(temp);
                temp = temp.Next;
            }
        }

        private void DisplayStudent(StudentNode student)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Roll No : " + student.RollNo);
            Console.WriteLine("Name    : " + student.Name);
            Console.WriteLine("Age     : " + student.Age);
            Console.WriteLine("Grade   : " + student.Grade);
        }
}
