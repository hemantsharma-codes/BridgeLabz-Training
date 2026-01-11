using System;
class StudentAgeCountingSort
{
    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 14, 18, 11, 15 };

        SortStudentAgesUsingCountingSort(studentAges, 10, 18);

        Console.WriteLine("Sorted Student Ages (Ascending Order):");
        DisplayStudentAges(studentAges);
    }

    // Entry utility method for Counting Sort
    static void SortStudentAgesUsingCountingSort(int[] ages, int minimumAge, int maximumAge)
    {
        int ageRange = maximumAge - minimumAge + 1;

        // Step 1: Count frequency of each age
        int[] ageFrequency = new int[ageRange];
        foreach (int age in ages)
        {
            ageFrequency[age - minimumAge]++;
        }

        // Step 2: Convert frequency array to sorted output
        int currentIndex = 0;
        for (int ageIndex = 0; ageIndex < ageRange; ageIndex++)
        {
            while (ageFrequency[ageIndex] > 0)
            {
                ages[currentIndex] = ageIndex + minimumAge;
                currentIndex++;
                ageFrequency[ageIndex]--;
            }
        }
    }

    // Utility method to display student ages
    static void DisplayStudentAges(int[] ages)
    {
        foreach (int age in ages)
            Console.Write(age + " ");
    }
}

