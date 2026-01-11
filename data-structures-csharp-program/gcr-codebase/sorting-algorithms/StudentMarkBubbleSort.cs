using System;
class StudentMarksBubbleSort
{
    static void Main()
    {
        int[] studentMarks = { 78, 45, 90, 66, 82 };

        SortMarksUsingBubbleSort(studentMarks);

        Console.WriteLine("Sorted Student Marks (Ascending Order):");
        DisplayMarks(studentMarks);
    }

    // Utility method that performs Bubble Sort
    static void SortMarksUsingBubbleSort(int[] marks)
    {
        bool isSwapPerformed;

        for (int passNumber = 0; passNumber < marks.Length - 1; passNumber++)
        {
            isSwapPerformed = false;

            for (int currentIndex = 0; currentIndex < marks.Length - passNumber - 1; currentIndex++)
            {
                if (marks[currentIndex] > marks[currentIndex + 1])
                {
                    SwapValues(marks, currentIndex, currentIndex + 1);
                    isSwapPerformed = true;
                }
            }

            // If no swap happens, array is already sorted
            if (!isSwapPerformed)
                break;
        }
    }

    // Utility method for swapping two values
    static void SwapValues(int[] data, int firstPosition, int secondPosition)
    {
        int tempValue = data[firstPosition];
        data[firstPosition] = data[secondPosition];
        data[secondPosition] = tempValue;
    }

    // Utility method to display array values
    static void DisplayMarks(int[] marks)
    {
        foreach (int mark in marks)
            Console.Write(mark + " ");
    }
}

