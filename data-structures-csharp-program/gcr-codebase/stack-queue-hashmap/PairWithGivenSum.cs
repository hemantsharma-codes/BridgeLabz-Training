using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static bool HasPairWithSum(int[] arr, int target)
    {
        Dictionary<int, bool> visited = new Dictionary<int, bool>();

        foreach (int num in arr)
        {
            int required = target - num;

            if (visited.ContainsKey(required))
            {
                Console.WriteLine($"Pair found: {required} + {num} = {target}");
                return true;
            }

            // Mark current number as visited
            if (!visited.ContainsKey(num))
                visited[num] = true;
        }

        return false;
    }

    static void Main()
    {
        int[] arr = { 8, 7, 2, 5, 3, 1 };
        int target = 10;

        bool result = HasPairWithSum(arr, target);

        if (!result)
            Console.WriteLine("No pair found");
    }
}

