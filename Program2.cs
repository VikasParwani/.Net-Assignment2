using system;

public interface IAccount
{
    void OpenAccount();
    void CloseAccount();
}

public interface ICustomer
{
    void DisplayCustomerDetail();
}

public class SavingsAccount : IAccount, ICustomer
{
    public string CustomerName { get; set; }
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public static string BankName { get; set; } = "My Bank";

    public SavingsAccount()
    {
        Console.WriteLine("Enter your name, A/C number, Balance");

    }

    public SavingsAccount(string name, int accountNumber, double balance)
    {
        CustomerName = name;
        AccountNumber = accountNumber;
        Balance = balance;
    }

    static SavingsAccount()
    {
        Console.WriteLine("Bank Name: " + BankName);
    }

    public void OpenAccount()
    {
        Console.WriteLine("Savings Account Opened");
    }

    public void CloseAccount()
    {
        Console.WriteLine("Savings Account Closed");
    }

    public void DisplayCustomerDetail()
    {
        Console.WriteLine("Customer Name: " + CustomerName);
        Console.WriteLine("Account Number: " + AccountNumber);
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Amount withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Amount deposited: " + amount);
    }

    public void CheckAndDisplayBalance()
    {
        Console.WriteLine("Current Balance: " + Balance);
    }
}