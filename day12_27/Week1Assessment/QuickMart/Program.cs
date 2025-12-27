using System;
public class Program
{
    public static void Main()
    {
        Saletransaction transaction = new Saletransaction();
        while (true)
        {
            Console.WriteLine("1. Create New Transaction (Enter Purchase and Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. CalCulate Profit/Loss (Recompute & print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    transaction.CreateNewTransaction();
                    break;
                case 2:
                    transaction.ViewLastTransaction();
                    break;
                case 3:
                    transaction.CalculateProfitOrLoss();
                    break;
                case 4:
                    Console.WriteLine("Thank You. Application Closed normally.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } 
    }
}