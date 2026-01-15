using System;
public class Program
{
    public delegate double Calculator(double a, double b);
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose operation: sum, sub, mul, div: ");
        string operation = Console.ReadLine().ToLower();

        if (operation == "sum")
        {
            Add(num1, num2);
        }
        else if (operation == "sub")
        {
            Subtract(num1, num2);
        }
        else if (operation == "mul")
        {
            Multiply(num1, num2);
        }
        else if (operation == "div")
        {
            Divide(num1, num2);
        }
        else
        {
            Console.WriteLine("Invalid operation selected.");
        }
    }

    public static void Add(double a, double b)
    {
        Calculator addition = (x, y) => x + y;
        Console.WriteLine("Sum: " + addition(a, b));
    }

    public static void Subtract(double a, double b)
    {
        Calculator subtraction = (x, y) => x - y;
        Console.WriteLine("Difference: " + subtraction(a, b));
    }

    public static void Multiply(double a, double b)
    {
        Calculator multiplication = (x, y) => x * y;
        Console.WriteLine("Product: " + multiplication(a, b));
    }

    public static void Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }

        Calculator division = (x, y) => x / y;
        Console.WriteLine("Quotient: " + division(a, b));
    }
}
