using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    static void FindZeroSumSubarrays(int[] arr)
    {
        // Dictionary to store sum and its indices
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        int sum = 0;

        // Base case: sum 0 at index -1
        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // If sum already exists, zero-sum subarray found
            if (map.ContainsKey(sum))
            {
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine($"Subarray found from index {startIndex + 1} to {i}");
                }
            }

            // Add current index to map
            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }

    static void Main()
    {
        int[] arr = { 3, 4, -7, 1, 3, -4, -2, -2 };

        FindZeroSumSubarrays(arr);
    }
}

