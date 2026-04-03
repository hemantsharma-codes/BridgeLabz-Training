using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.AiDrivenResumeScreeningSystem
{
    class Menu
    {
        private Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        private Resume<DataScientist> dsResumes = new Resume<DataScientist>();

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- AI Resume Screening System ---");
                Console.WriteLine("1. Add Software Engineer Resume");
                Console.WriteLine("2. Add Data Scientist Resume");
                Console.WriteLine("3. Screen All Resumes");
                Console.WriteLine("0. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddSoftwareEngineer();
                        break;
                    case 2:
                        AddDataScientist();
                        break;
                    case 3:
                        ScreenAllResumes();
                        break;
                }

            } while (choice != 0);
        }

        private void AddSoftwareEngineer()
        {
            Console.Write("Enter candidate name: ");
            string name = Console.ReadLine();
            seResumes.AddResume(new SoftwareEngineer(name));
        }

        private void AddDataScientist()
        {
            Console.Write("Enter candidate name: ");
            string name = Console.ReadLine();
            dsResumes.AddResume(new DataScientist(name));
        }

        // 🔹 Covariance used here
        private void ScreenResumes(IEnumerable<JobRole> resumes)
        {
            foreach (var resume in resumes)
            {
                resume.Evaluate();
            }
        }

        private void ScreenAllResumes()
        {
            Console.WriteLine("\n--- Software Engineer Resumes ---");
            ScreenResumes(seResumes.GetResumes());

            Console.WriteLine("\n--- Data Scientist Resumes ---");
            ScreenResumes(dsResumes.GetResumes());
        }
    }

}
