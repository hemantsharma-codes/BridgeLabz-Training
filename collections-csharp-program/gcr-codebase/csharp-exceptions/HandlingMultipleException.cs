using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class HandlingMultipleException
    {
        static void Main(string[] args)
        {
            int[] numbers = null;

            Console.WriteLine("Enter the index that you want to access..");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                int value = numbers[index];
                Console.WriteLine($"Value at index {index}: {value}");
            }
            catch (IndexOutOfRangeException)
            {
                System.Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("Array is not initialized!");
            }
        }
    }
}
