using System;
class BankAccount{
    // static variable (shared by all accounts)
    public static string bankName = "National Bank";
    // static variable to count accounts
    private static int totalAccounts = 0;

    // readonly variable (cannot be changed after constructor)
    public readonly int AccountNumber;

    // Instance variable
    private string accountHolderName;

    // Constructor (using this keyword)
    public BankAccount(int AccountNumber, string accountHolderName){
        this.AccountNumber = AccountNumber;
        this.accountHolderName = accountHolderName;
        totalAccounts++;
    }
    // Instance method
    public void DisplayAccount(){
        Console.WriteLine("Bank Name          : " + bankName);
        Console.WriteLine("Account Number     : " + AccountNumber);
        Console.WriteLine("Account Holder     : " + accountHolderName);
    }

    // static method
    public static void GetTotalAccounts(){
        Console.WriteLine("Total Accounts Created : " + totalAccounts);
    }
}
class BankAccountSystem{
    static void Main(string[] args){
        Console.Write("Enter Account Number: ");
        int accNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        BankAccount acc1 = new BankAccount(accNo, name);

        Console.WriteLine();

        //is operator check
        if (acc1 is BankAccount){
            Console.WriteLine("Valid BankAccount object.\n");
            acc1.DisplayAccount();
        }

        Console.WriteLine();
        BankAccount.GetTotalAccounts();
    }
}

