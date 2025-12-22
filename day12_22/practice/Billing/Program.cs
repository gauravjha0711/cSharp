using System;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main()
    {
        Billing billing = new Billing();  //calling default constructor
        Console.WriteLine($"Number1: {billing.Number1}");
        Console.WriteLine($"Number2: {billing.Number2}");

        Billing billing1 = new Billing(10, 2);  //calling parameterized constructor
        Console.WriteLine($"Number1: {billing1.Number1}");
        Console.WriteLine($"Number2: {billing1.Number2}");
    }
}