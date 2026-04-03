using System;
class EmployeeIdInsertionSort
{
    static void Main()
    {
        int[] employeeIds = { 105, 101, 109, 103, 102 };

        SortEmployeeIdsUsingInsertionSort(employeeIds);

        Console.WriteLine("Sorted Employee IDs (Ascending Order):");
        DisplayEmployeeIds(employeeIds);
    }

    // Utility method that performs Insertion Sort
    static void SortEmployeeIdsUsingInsertionSort(int[] employeeIds)
    {
        for (int unsortedIndex = 1; unsortedIndex < employeeIds.Length; unsortedIndex++)
        {
            int currentEmployeeId = employeeIds[unsortedIndex];
            int sortedIndex = unsortedIndex - 1;

            // Shift elements of the sorted part to make space
            while (sortedIndex >= 0 && employeeIds[sortedIndex] > currentEmployeeId)
            {
                employeeIds[sortedIndex + 1] = employeeIds[sortedIndex];
                sortedIndex--;
            }

            // Insert the current element at correct position
            employeeIds[sortedIndex + 1] = currentEmployeeId;
        }
    }

    // Utility method to display employee IDs
    static void DisplayEmployeeIds(int[] employeeIds)
    {
        foreach (int id in employeeIds)
            Console.Write(id + " ");
    }
}

