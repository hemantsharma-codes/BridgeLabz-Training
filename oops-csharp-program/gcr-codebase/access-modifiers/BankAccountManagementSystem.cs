using System;
class BankAccount{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolder, double balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to get balance
    public double GetBalance(){
        return balance;
    }

    // Public method to deposit money
    public void Deposit(double amount){
        balance += amount;
    }

    // Public method to withdraw money
    public void Withdraw(double amount){
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient balance.");
    }
}

// Subclass to demonstrate access modifiers
class SavingsAccount : BankAccount{
    public SavingsAccount(int accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance){
    }

    public void DisplaySavingsAccount(){
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Account Holder : " + accountHolder);
        Console.WriteLine("Balance        : " + GetBalance());
    }
}
class BankAccountManagementSystem{
    static void Main(string[] args){
        Console.Write("Enter Account Number: ");
        int accNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Account Holder Name: ");
        string holder = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        double balance = double.Parse(Console.ReadLine());

        SavingsAccount sa = new SavingsAccount(accNo, holder, balance);

        Console.WriteLine("\nAccount Details:");
        sa.DisplaySavingsAccount();

        Console.Write("\nEnter Deposit Amount: ");
        double deposit = double.Parse(Console.ReadLine());
        sa.Deposit(deposit);

        Console.Write("\nEnter Withdrawal Amount: ");
        double withdraw = double.Parse(Console.ReadLine());
        sa.Withdraw(withdraw);

        Console.WriteLine("\nUpdated Account Details:");
        sa.DisplaySavingsAccount();
    }
}

