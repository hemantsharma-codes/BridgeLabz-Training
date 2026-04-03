using System;
using System.Collections.Generic;

class TwoSumProblem
{
    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int required = target - nums[i];

            if (map.ContainsKey(required))
            {
                return new int[] { map[required], i };
            }

            // Store value with its index
            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        return new int[] { -1, -1 }; // No solution
    }

    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);

        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}

