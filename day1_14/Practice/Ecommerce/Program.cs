using System;
public class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException(string message) : base(message)
    {
    }
}
public class EcommerceShop
{
    public string UserName { get; set; }
    public double WalletBalance { get; set; }
    public double TotalPurchaseAmount { get; set; }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter User Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Wallet Balance:");
        double balance = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Total Purchase Amount:");
        double amount = double.Parse(Console.ReadLine());
        try
        {
            EcommerceShop shop = MakePayment(name, balance, amount);
            Console.WriteLine($"Payment Successful! Remaining Wallet Balance: {shop.WalletBalance}");
        }
        catch(InsufficientWalletBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static EcommerceShop MakePayment(string name, double balance, double amount)
    {
        EcommerceShop shop = new EcommerceShop();
        shop.UserName = name;
        shop.WalletBalance = balance;
        shop.TotalPurchaseAmount = amount;
        if(shop.WalletBalance >= shop.TotalPurchaseAmount)
        {
            shop.WalletBalance -= shop.TotalPurchaseAmount;
            return shop;
        }
        else
        {
            throw new InsufficientWalletBalanceException("Insufficient Balance in your digital wallet.");
        }
        return shop;
    }
}