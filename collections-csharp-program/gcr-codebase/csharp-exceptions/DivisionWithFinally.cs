using System;
class DivisionWithFinally
{
  static void Main(string[] args)
  {
    try
    {
      Console.WriteLine("Enter the nemerator: ");
      int numerator = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the denominator: ");
      int denominator = int.Parse(Console.ReadLine());

      int result = numerator / denominator;
      Console.WriteLine($"Result: {result}");
    }
    catch (DivideByZeroException)
    {
      Console.WriteLine("Error: Cannot divide by zero!");
    }
    catch (FormatException)
    {
      Console.WriteLine("Error: Please enter valid integers!");
    }
    finally
    {
      Console.WriteLine("Operation completed.");
    }
  }
}