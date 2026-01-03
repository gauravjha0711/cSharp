using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(101, "Gaurav");
        hashtable.Add(102, "Kundan");
        hashtable.Add(103, "Krishna");
        hashtable.Add(104, "Shubham");
        ICollection key = hashtable.Keys;
        Console.WriteLine("All keys are: ");
        foreach(var k in key)
        {
            Console.WriteLine(k);
        }
        ICollection values = hashtable.Values;
        Console.WriteLine("All values are: ");
        foreach(var v in values)
        {
            Console.WriteLine(v);
        }

        Console.WriteLine("Keys and Values are: ");
        foreach(var k in key)
        {
            Console.WriteLine(k + " : " + hashtable[k]);
        }

        Console.WriteLine("Enter key to search value: ");
        int searchKey = Convert.ToInt32(Console.ReadLine());
        if(hashtable.ContainsKey(searchKey))
        {
            Console.WriteLine("Key " + searchKey + " is found in values: " + hashtable[searchKey]);
        }
        else
        {
            Console.WriteLine("Key " + searchKey + " is not present");
        }
    }
}