using System;
class NestedTryCatchDemo
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.Write("Enter the index to access: ");
        int index = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        try
        {
            int value = numbers[index];  // Outer try: accessing array element

            try
            {
                int result = value / divisor;  // Inner try: division
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter integers only.");
        }
    }
}