class StudentMain
{
    static void Main(string[] args)
    {
        StudentLinkedList list = new StudentLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Record Management ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Delete by Roll Number");
            Console.WriteLine("5. Search by Roll Number");
            Console.WriteLine("6. Update Grade");
            Console.WriteLine("7. Display All");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(list, 1);
                    break;
                case 2:
                    AddStudent(list, 2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddStudent(list, 3, pos);
                    break;
                case 4:
                    Console.Write("Enter Roll No: ");
                    list.DeleteByRollNo(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    Console.Write("Enter Roll No: ");
                    list.SearchByRollNo(int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.Write("Enter Roll No: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Grade: ");
                    char g = char.Parse(Console.ReadLine());
                    list.UpdateGrade(r, g);
                    break;
                case 7:
                    list.DisplayAll();
                    break;
            }

        } while (choice != 0);
    }

    static void AddStudent(StudentLinkedList list, int mode, int position = 0)
    {
        Console.Write("Enter Roll No: ");
        int roll = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());

        if (mode == 1)
            list.AddAtBeginning(roll, name, age, grade);
        else if (mode == 2)
            list.AddAtEnd(roll, name, age, grade);
        else
            list.AddAtPosition(position, roll, name, age, grade);
    }
}
