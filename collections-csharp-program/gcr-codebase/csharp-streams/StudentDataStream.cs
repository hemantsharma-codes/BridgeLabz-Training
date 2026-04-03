//using System;
//using System.IO;

//namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_streams
//{
//    class StudentDataStream
//    {
//        static string filePath = "student.dat";

//        static void Main()
//        {
//            try
//            {
//                WriteStudentData();
//                ReadStudentData();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error occurred: " + ex.Message);
//            }
//        }

//        // Utility method to write primitive data
//        static void WriteStudentData()
//        {
//            Console.Write("Enter Roll Number: ");
//            int rollNo = int.Parse(Console.ReadLine());

//            Console.Write("Enter Name: ");
//            string name = Console.ReadLine();

//            Console.Write("Enter GPA: ");
//            double gpa = double.Parse(Console.ReadLine());

//            FileStream fs = new FileStream(filePath, FileMode.Create);
//            BinaryWriter writer = new BinaryWriter(fs);

//            writer.Write(rollNo);
//            writer.Write(name);
//            writer.Write(gpa);

//            writer.Close();
//            fs.Close();

//            Console.WriteLine("\nStudent data saved successfully.\n");
//        }

//        // Utility method to read primitive data
//        static void ReadStudentData()
//        {
//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("File not found.");
//                return;
//            }

//            FileStream fs = new FileStream(filePath, FileMode.Open);
//            BinaryReader reader = new BinaryReader(fs);

//            int rollNo = reader.ReadInt32();
//            string name = reader.ReadString();
//            double gpa = reader.ReadDouble();

//            reader.Close();
//            fs.Close();

//            Console.WriteLine("---- Student Details ----");
//            Console.WriteLine("Roll Number : " + rollNo);
//            Console.WriteLine("Name        : " + name);
//            Console.WriteLine("GPA         : " + gpa);
//        }
//    }
//}
