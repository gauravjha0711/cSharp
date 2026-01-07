using System;
using System.Collections.Generic;
using System.Linq;
public class Ledger<T> where T : Transaction
{
    private List<T> entries = new List<T>();

    public void AddEntry(T entry)
    {
        entries.Add(entry);
    }

    public List<T> GetTransactionsByDate(DateTime date)
    {
        return entries.Where(e => e.Date.Date == date.Date).ToList();
    }

    public decimal CalculateTotal()
    {
        return entries.Sum(e => e.Amount);
    }
    public List<T> GetAll()
    {
        return entries;
    }
}