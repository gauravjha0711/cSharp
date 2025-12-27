using System;
public class Saletransaction
{
    public string InVoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public double PurchaseAmount { get; set; }
    public double SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; }
    public double ProfitOrLossAmount { get; set; }
    public double ProfitMarginPercent { get; set; }
    public static double SaleTransactionTotal { get; set; }
    public static double LastTransaction { get; set; }
    public static bool HasLastTransaction { get; set; }
    public void CreateNewTransaction()
    {
        Console.Write("Enter Invoice No: ");
        InVoiceNo = Console.ReadLine();
        Console.Write("Enter Customer Name: ");
        CustomerName = Console.ReadLine();
        Console.Write("Enter Item Name: ");
        ItemName = Console.ReadLine();
        Console.Write("Enter Quantity: ");
        Quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Purchase Amount (total): ");
        PurchaseAmount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Selling Amount (total): ");
        SellingAmount = Convert.ToDouble(Console.ReadLine());

        LastTransaction = SellingAmount - PurchaseAmount;
        HasLastTransaction = true;
        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine($"Status: {(LastTransaction > 0 ? "PROFIT" : LastTransaction < 0 ? "LOSS" : "BREAK-EVEN")}");
        Console.WriteLine($"Profit/Loss Amount: {Math.Abs(LastTransaction)}");
        
        Console.WriteLine($"Profit Margin % : {(LastTransaction != 0 ? Math.Round((Math.Abs(LastTransaction) / PurchaseAmount) * 100, 2) : 0)}");
    }
    public void ViewLastTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available to show.");
            return;
        }

        Console.WriteLine("----- Last Sale Transaction -----");
        Console.WriteLine($"Invoice No: {InVoiceNo}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Purchase Amount: {PurchaseAmount}");
        Console.WriteLine($"Selling Amount: {SellingAmount}");
        Console.WriteLine($"Status: {(LastTransaction > 0 ? "PROFIT" : LastTransaction < 0 ? "LOSS" : "BREAK-EVEN")}");
        Console.WriteLine($"Profit/Loss Amount: {Math.Abs(LastTransaction)}");
        
        Console.WriteLine($"Profit Margin (%) : {(LastTransaction != 0 ? Math.Round((Math.Abs(LastTransaction) / PurchaseAmount) * 100, 2) : 0)}");
        Console.WriteLine("---------------------------------");
    }
    public void CalculateProfitOrLoss()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available to calculate profit/loss.");
            return;
        }

        ProfitOrLossAmount = SellingAmount - PurchaseAmount;
        ProfitOrLossStatus = ProfitOrLossAmount > 0 ? "PROFIT" : ProfitOrLossAmount < 0 ? "LOSS" : "BREAK-EVEN";
        ProfitMarginPercent = ProfitOrLossAmount != 0 ? (Math.Abs(ProfitOrLossAmount) / PurchaseAmount) * 100 : 0;
        
        ProfitMarginPercent = Math.Round(ProfitMarginPercent, 2);
        Console.WriteLine("----- Recomputed Profit/Loss -----");
        Console.WriteLine($"Status: {ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {Math.Abs(ProfitOrLossAmount)}");
        Console.WriteLine($"Profit Margin % : {ProfitMarginPercent}");
        Console.WriteLine("----------------------------------");
    }
}