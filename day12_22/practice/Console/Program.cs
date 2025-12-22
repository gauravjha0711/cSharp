using System;
public class Calc
{
    public static void Main()
    {
        int n1 = 85;
        int n2 = 90;
        int result = 0;
        int n3=0;
        int n4=0;
        Calculator calculator = new Calculator();  //calling default constructor
        calculator.Addition(n1, n2, out result, out n3, out n4);
        Console.WriteLine($"First number: {n3}, Second number: {n4}");
        Console.WriteLine($"Addition of {n3} and {n4} is: {result}");
    }
}