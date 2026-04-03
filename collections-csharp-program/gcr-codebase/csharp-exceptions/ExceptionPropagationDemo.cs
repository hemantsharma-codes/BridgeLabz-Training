using System;

class ExceptionPropagationDemo
{
    static void Method1()
    {
        Console.WriteLine("Inside Method1");
        int numerator = 10;
        int denominator = 0;
        int result = numerator / denominator;
        Console.WriteLine(result);
    }

    static void Method2()
    {
        Console.WriteLine("Inside Method2");
        try
        {
            Method1();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Exception caught in Method2, re-throwing...");
            throw;  // re-throw to propagate to Main
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Inside Main");
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}