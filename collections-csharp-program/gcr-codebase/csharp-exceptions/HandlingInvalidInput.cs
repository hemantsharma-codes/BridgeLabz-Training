class HandlingInvalidInput
{
  private static double CalculateInterest(double amount, double rate, int years)
  {
    if (amount < 0 || rate < 0)
    {
      throw new ArgumentException("Amount and rate must be positive");
    }

    double interest = (amount * rate * years) / 100;
    return interest;
  }
  static void Main(string[] args)
  {
    try
    {
      Console.WriteLine("Enter Principal amount: ");
      double amount = Convert.ToInt64(Console.ReadLine());

      Console.WriteLine("Enter interest rate: ");
      double rate = Convert.ToInt64(Console.ReadLine());

      Console.WriteLine("Enter number of years: ");
      int years = Convert.ToInt32(Console.ReadLine());

      double interest = CalculateInterest(amount, rate, years);
      Console.WriteLine($"Calculate interest: {interest}");
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine("Invalid input: " + ex.Message);
    }
    catch (FormatException)
    {
      Console.WriteLine("Invalid input: Please enter neumeric values only.");
    }
  }
}