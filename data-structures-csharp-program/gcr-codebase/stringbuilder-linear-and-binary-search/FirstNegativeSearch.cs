using System;
class FirstNegativeSearch
{
    static int FindFirstNegative(int[] numbers)
    {
        for(int i=0;i<numbers.Length;i++)
        {
            if(numbers[i] < 0)
            {
                return numbers[i];   // first negative found
            }
        }

        return 0;   // indicates no negative number
    }

    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        for(int i=0;i<size;i++)
        {
            Console.Write("Enter element "+(i+1)+": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int result = FindFirstNegative(arr);

        if (result < 0)
        {
            Console.WriteLine("First negative number is: "+result);
        }
        else
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }
}

