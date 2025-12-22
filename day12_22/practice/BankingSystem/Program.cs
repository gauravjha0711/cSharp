using System;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();  //calling default constructor
        int number1 = 20;
        int number2 = 30;
        int sum = calculator.Add(number1, number2);
        Console.WriteLine($"Sum of {number1} and {number2} is: {sum}");

        calculator.Subtract(number2, number1);

        int multiply = calculator.Multiply();
        Console.WriteLine($"Multiplication of {number1} and {number2} is: {multiply}");

        Calculator calculator1 = new Calculator(10, 2);  //calling parameterized constructor
        calculator1.Divide();


        
    }
}