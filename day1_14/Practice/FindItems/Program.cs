using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    // Given SortedDictionary
    public static SortedDictionary<string, long> itemDetails =
        new SortedDictionary<string, long>()
        {
            { "Pen", 50 },
            { "Pencil", 20 },
            { "Notebook", 100 },
            { "Eraser", 10 }
        };

    //Find item details by sold count
    public static SortedDictionary<string, long> FindItemDetails(long soldCount)
    {
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        foreach (var item in itemDetails)
        {
            if (item.Value == soldCount)
            {
                result.Add(item.Key, item.Value);
            }
        }

        return result;
    }
    //Find minimum and maximum sold items
    public static List<string> FindMinandMaxSoldItems()
    {
        List<string> result = new List<string>();

        var minItem = itemDetails.Aggregate((x, y) => x.Value < y.Value ? x : y);
        var maxItem = itemDetails.Aggregate((x, y) => x.Value > y.Value ? x : y);

        result.Add(minItem.Key);
        result.Add(maxItem.Key);

        return result;
    }
    //Find item details by sold count
    public static Dictionary<string, long> SortByCount()
    {
        return itemDetails
            .OrderBy(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter sold count:");
        long soldCount = Convert.ToInt64(Console.ReadLine());

        // Find item by sold count
        var foundItems = FindItemDetails(soldCount);

        if (foundItems.Count == 0)
        {
            Console.WriteLine("Invalid sold count");
        }
        else
        {
            foreach (var item in foundItems)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        // Find min and max sold items
        List<string> minMaxItems = FindMinandMaxSoldItems();
        Console.WriteLine("Minimum sold item: " + minMaxItems[0]);
        Console.WriteLine("Maximum sold item: " + minMaxItems[1]);

        // Sort by count
        Console.WriteLine("Items sorted by sold count:");
        var sortedItems = SortByCount();
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
