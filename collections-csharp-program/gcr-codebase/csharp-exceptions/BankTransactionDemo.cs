using System;
// Custom exception for insufficient funds
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {balance}");
    }
}

class BankTransactionDemo
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(5000); // Initial balance

        Console.Write("Enter amount to withdraw: ");
        double amount = double.Parse(Console.ReadLine());

        try
        {
            account.Withdraw(amount);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a numeric value.");
        }
    }
}