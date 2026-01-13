using System;
class FirstAndLastOccurrence
{
    static int FindFirst(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;        // possible answer
                right = mid - 1;     // move left
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    static int FindLast(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;        // possible answer
                left = mid + 1;      // move right
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter sorted array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter target element:");
        int target = int.Parse(Console.ReadLine());

        int firstIndex = FindFirst(arr, target);
        int lastIndex = FindLast(arr, target);

        if (firstIndex == -1)
        {
            Console.WriteLine("Target element not found.");
        }
        else
        {
            Console.WriteLine("First occurrence index: " + firstIndex);
            Console.WriteLine("Last occurrence index: " + lastIndex);
        }
    }
}

