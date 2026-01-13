using System;
class LinearAndBinarySearch
{
    //Linear Search
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        bool[] visited = new bool[n+1];

        // mark visited positives
        for(int i=0;i<n;i++)
        {
            if(arr[i]>0 && arr[i]<=n)
            {
                visited[arr[i]] = true;
            }
        }

        // find first unvisited positive
        for(int i=1;i<=n;i++)
        {
            if(!visited[i])
            {
                return i;
            }
        }

        return n+1;
    }

    // Binary Search
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left<=right)
        {
            int mid = left+(right-left)/2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid+1;
            }
            else
            {
                right = mid-1;
            }
        }

        return -1;
    }

    // Simple Sorting (Bubble Sort)
    static void SortArray(int[] arr)
    {
        for (int i=0;i<arr.Length-1;i++)
        {
            for (int j=0;j<arr.Length-i-1;j++)
            {
                if (arr[j]>arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for(int i=0;i<n;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Linear Search part
        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine("First missing positive integer: "+missing);

        // Binary Search part
        Console.WriteLine("Enter target element:");
        int target = int.Parse(Console.ReadLine());

        SortArray(arr);   // required before binary search

        int index = BinarySearch(arr, target);

        if (index != -1)
        {
            Console.WriteLine("Target found at index: "+index);
        }
        else
        {
            Console.WriteLine("Target not found.");
        }
    }
}

