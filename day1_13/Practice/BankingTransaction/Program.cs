using System;
class ArgumentException : Exception
{
    public ArgumentException(string message) : base(message) { }
}
class InvalidOperationException : Exception
{
    public InvalidOperationException(string message) : base(message) { }
}
public class Program
{
    public static void Main()
    {
        Account account = new Account();
        Console.Write("Enter Account Number ");
        account.AccountNumber = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("Select operation: 1. Deposit 2. Withdraw 3. Check Balance 4. Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter amount to deposit: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                double newBalance = account.Deposit(amount);
                Console.WriteLine("Deposit successful. New Balance: " + newBalance);
            }
            else if (choice == "2")
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                double newBalance = account.Withdraw(amount);
                Console.WriteLine("Withdrawal processed. New Balance: " + newBalance);
            }
            else if (choice == "3")
            {
                double balance = account.GetBalance();
                Console.WriteLine("Current Balance: " + balance);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
public class Account
{
    public string AccountNumber {get; set;}
    public double Balance {get; set;}
    public double Deposit(double amount)
    {
        try
        {
            if (amount > 0)
            {
                Balance += amount;
                return Balance;
            }
            else
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return Balance;
        }
    }
    public double Withdraw(double amount)
    {
        try
        {
            if(amount > 0)
            {
                if(amount <= Balance)
                {
                    Balance -= amount;
                    return Balance;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds for withdrawal.");
                }
            }
            else
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return Balance;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return Balance;
        }
    }
    public double GetBalance()
    {
        return Balance;
    }
}