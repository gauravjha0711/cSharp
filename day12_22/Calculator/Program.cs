using System;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main()
    {
        // Calculator calculator = new Calculator();  //calling default constructor
        // int number1 = 20;
        // int number2 = 30;
        // int sum = calculator.Add(number1, number2);
        // Console.WriteLine($"Sum of {number1} and {number2} is: {sum}");

        // calculator.Subtract(number2, number1);

        // int multiply = calculator.Multiply();
        // Console.WriteLine($"Multiplication of {number1} and {number2} is: {multiply}");

        // Calculator calculator1 = new Calculator(10, 2);  //calling parameterized constructor
        // calculator1.Divide();


        // Calculator calculator2 = new Calculator();
        // int n1 = 10;
        // int n2 = 20;
        // Console.WriteLine("Pass by Value:");
        // Console.WriteLine($"Before Swapping: n1 = {n1}, n2 = {n2}");
        // calculator2.Swap(n1, n2);
        // Console.WriteLine($"After Swapping: n1 = {n1}, n2 = {n2}");

        // int n3 = 10;
        // int n4 = 20;
        // Console.WriteLine("Pass by Reference:");
        // Console.WriteLine($"Before Swapping: n1 = {n3}, n2 = {n4}");
        // calculator2.SwapRef(ref n3, ref n4);
        // Console.WriteLine($"After Swapping: n1 = {n3}, n2 = {n4}");

        Calculator calculator3 = new Calculator();
        int num1 = 30;
        int num2 = 50;
        int result, num3, num4;
        calculator3.Addtion(num1, num2, out result, out num3, out num4);
        Console.WriteLine($"First number: {num3}, Second number: {num4}");
        Console.WriteLine($"Addition of {num3} and {num4} is: {result}");
    }
}