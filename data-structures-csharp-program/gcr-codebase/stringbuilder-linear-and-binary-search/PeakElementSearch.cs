using System;
class PeakElementSearch
{
    static int FindPeakElement(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;   // move right
            }
            else
            {
                right = mid;     // move left
            }
        }

        return left;  // peak index
    }

    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int peakIndex = FindPeakElement(arr);

        Console.WriteLine("Peak element index: " + peakIndex);
        Console.WriteLine("Peak element value: " + arr[peakIndex]);
    }
}

