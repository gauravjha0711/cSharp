using System;
using System.Net;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main()
    {
        Utility utility = new Utility();  //calling default constructor
        utility.num1 = 15;
        utility.num2 = 25;
        utility.Result = utility.num1 + utility.num2;
        Console.WriteLine($"Result of adding {utility.num1} and {utility.num2} is: {utility.Result}");
        Console.WriteLine($"Number1: {utility.num1}");
        Console.WriteLine($"Number2: {utility.num2}");
    }
}