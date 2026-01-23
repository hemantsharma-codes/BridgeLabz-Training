using System;
class DivisionWithExceptionHandling
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter only numeric values.");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Something went wrong.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}

