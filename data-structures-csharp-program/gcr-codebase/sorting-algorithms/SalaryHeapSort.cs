using System;
class SalaryHeapSort
{
    static void Main()
    {
        int[] salaryDemands = { 60000, 45000, 80000, 50000, 70000 };

        SortSalaryDemandsUsingHeapSort(salaryDemands);

        Console.WriteLine("Sorted Salary Demands (Ascending Order):");
        DisplaySalaryDemands(salaryDemands);
    }

    // Entry utility method for Heap Sort
    static void SortSalaryDemandsUsingHeapSort(int[] salaries)
    {
        int totalElements = salaries.Length;

        // Step 1: Build Max Heap
        for (int index = totalElements / 2 - 1; index >= 0; index--)
        {
            RestoreHeapProperty(salaries, totalElements, index);
        }

        // Step 2: Extract elements from heap one by one
        for (int lastIndex = totalElements - 1; lastIndex > 0; lastIndex--)
        {
            SwapValues(salaries, 0, lastIndex);

            RestoreHeapProperty(salaries, lastIndex, 0);
        }
    }

    // Utility method to maintain Max Heap property
    static void RestoreHeapProperty(int[] salaries, int heapSize, int rootIndex)
    {
        int largestIndex = rootIndex;
        int leftChildIndex = 2 * rootIndex + 1;
        int rightChildIndex = 2 * rootIndex + 2;

        if (leftChildIndex < heapSize && salaries[leftChildIndex] > salaries[largestIndex])
        {
            largestIndex = leftChildIndex;
        }

        if (rightChildIndex < heapSize && salaries[rightChildIndex] > salaries[largestIndex])
        {
            largestIndex = rightChildIndex;
        }

        if (largestIndex != rootIndex)
        {
            SwapValues(salaries, rootIndex, largestIndex);
            RestoreHeapProperty(salaries, heapSize, largestIndex);
        }
    }

    // Utility method to swap values
    static void SwapValues(int[] data, int firstPosition, int secondPosition)
    {
        int temporaryValue = data[firstPosition];
        data[firstPosition] = data[secondPosition];
        data[secondPosition] = temporaryValue;
    }

    // Utility method to display salaries
    static void DisplaySalaryDemands(int[] salaries)
    {
        foreach (int salary in salaries)
            Console.Write(salary + " ");
    }
}

