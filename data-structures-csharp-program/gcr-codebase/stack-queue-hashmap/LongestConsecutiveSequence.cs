using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static int FindLongestConsecutive(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();

        // Add all elements to HashSet
        foreach (int num in arr)
            set.Add(num);

        int longest = 0;

        foreach (int num in set)
        {
            // Check if it is the start of a sequence
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int count = 1;

                // Count consecutive numbers
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };

        int result = FindLongestConsecutive(arr);
        Console.WriteLine("Length of Longest Consecutive Sequence: " + result);
    }
}

