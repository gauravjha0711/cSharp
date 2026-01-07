using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        while (true)
        {
            Console.WriteLine("\nWelcome to the Cash Ledger Application");
            Console.WriteLine("1. Add Income Transaction");
            Console.WriteLine("2. Add Expense Transaction");
            Console.WriteLine("3. View Summary");
            Console.WriteLine("4. Show All Transactions");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");

            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Id: ");
                    int incomeId = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter Amount: ");
                    decimal incomeAmount = decimal.Parse(Console.ReadLine()!);

                    Console.Write("Enter Description: ");
                    string incomeDescription = Console.ReadLine()!;

                    Console.Write("Enter Source: ");
                    string source = Console.ReadLine()!;

                    incomeLedger.AddEntry(new IncomeTransaction
                    {
                        Id = incomeId,
                        Date = DateTime.Today,
                        Amount = incomeAmount,
                        Description = incomeDescription,
                        Source = source
                    });

                    Console.WriteLine("Income added successfully!");
                    break;

                case 2:
                    Console.Write("Enter Id: ");
                    int expenseId = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter Amount: ");
                    decimal expenseAmount = decimal.Parse(Console.ReadLine()!);

                    Console.Write("Enter Description: ");
                    string expenseDescription = Console.ReadLine()!;

                    Console.Write("Enter Category: ");
                    string category = Console.ReadLine()!;

                    expenseLedger.AddEntry(new ExpenseTransaction
                    {
                        Id = expenseId,
                        Date = DateTime.Today,
                        Amount = expenseAmount,
                        Description = expenseDescription,
                        Category = category
                    });

                    Console.WriteLine("Expense added successfully!");
                    break;

                case 3:
                    decimal totalIncome = incomeLedger.CalculateTotal();
                    decimal totalExpense = expenseLedger.CalculateTotal();
                    decimal netBalance = totalIncome - totalExpense;

                    Console.WriteLine("\n----- PETTY CASH SUMMARY -----");
                    Console.WriteLine($"Total Income  : {totalIncome}");
                    Console.WriteLine($"Total Expense : {totalExpense}");
                    Console.WriteLine($"Net Balance   : {netBalance}");
                    break;

                case 4:
                    Console.WriteLine("\n----- ALL TRANSACTIONS -----");

                    List<Transaction> allTransactions = new List<Transaction>();
                    allTransactions.AddRange(incomeLedger.GetAll());
                    allTransactions.AddRange(expenseLedger.GetAll());

                    foreach (Transaction txn in allTransactions)
                    {
                        Console.WriteLine(txn.GetSummary());
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting application...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
