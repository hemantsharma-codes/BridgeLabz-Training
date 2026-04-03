using System;
using System.Diagnostics;
class SearchComparison
{
    // Linear Search : O(N)
    static int LinearSearch(int[] data, int target)
    {
        for (int i=0;i<data.Length;i++)
        {
            if (data[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    // Binary Search : O(log N)
    static int BinarySearch(int[] data, int target)
    {
        int left = 0;
        int right = data.Length - 1;

        while (left <= right)
        {
            int mid = left+(right-left)/2;

            if (data[mid] == target)
            {
                return mid;
            }
            else if (data[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int size = 1000000;
        int[] dataset = new int[size];

        // Fill dataset
        for (int i=0;i<size;i++)
        {
            dataset[i] = i+1;
        }

        int target = size;

        Stopwatch sw = new Stopwatch();

        // Linear Search
        sw.Start();
        int linearIndex = LinearSearch(dataset, target);
        sw.Stop();

        Console.WriteLine("Linear Search Result:");
        Console.WriteLine("Index Found : " + linearIndex);
        Console.WriteLine("Time Taken (ms) : " + sw.ElapsedMilliseconds);

        // Sorting for Binary Search
        Array.Sort(dataset);

        // Binary Search
        sw.Reset();
        sw.Start();
        int binaryIndex = BinarySearch(dataset, target);
        sw.Stop();

        Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine("Index Found : " + binaryIndex);
        Console.WriteLine("Time Taken (ms) : " + sw.ElapsedMilliseconds);
    }
}

