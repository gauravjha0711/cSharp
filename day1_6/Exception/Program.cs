using System;
public class Program
{
    public static void Main()
    {
        int num1 = 0;
        int num2 = 0;
        int result = 0;
        // result = num1 / num2;
        // Console.WriteLine($"The result of division of {num1} by {num2} is: {result}");

        // try
        // {
        //     Console.WriteLine("Enter first number:");
        //     num1 = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Enter second number:");
        //     num2 = Convert.ToInt32(Console.ReadLine());
        //     result = num1 / num2;
        //     Console.WriteLine($"The result of division of {num1} by {num2} is: {result}");
        // }
        // catch (DivideByZeroException ex)
        // {
        //     Console.WriteLine("Error: Division by zero is not allowed.");
        //     Console.WriteLine(ex.Message);
        // }
        // catch (FormatException ex)
        // {
        //     Console.WriteLine("Error: Invalid input format. Please enter numeric values.");
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Execution completed.");
        // }



        //nested try-catch
        // try
        // {
        //     Console.WriteLine("Enter first number:");
        //     num1 = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Enter second number:");
        //     num2 = Convert.ToInt32(Console.ReadLine());
        //     try
        //     {
        //         result = num1 / num2;
        //         Console.WriteLine($"The result of division of {num1} by {num2} is: {result}");
        //     }
        //     catch (DivideByZeroException ex)
        //     {
        //         Console.WriteLine("Error: Division by zero is not allowed.");
        //         Console.WriteLine(ex.Message);
        //     }
        // }
        // catch (FormatException ex)
        // {
        //     Console.WriteLine("Error: Invalid input format. Please enter numeric values.");
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Execution completed.");
        // }



        //indexoutofrange exception
        // try
        // {
        //     int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        //     Console.WriteLine(numbers[5]);
        // }
        // catch (IndexOutOfRangeException ex)
        // {
        //     Console.WriteLine("Error: Attempted to access an index that is out of range.");
        //     Console.WriteLine(ex.Message);
        // }
        // finally
        // {
        //     Console.WriteLine("Execution completed.");
        // }



        try
        {
            throw new MyException("user Defined exception");
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception Caught here: " + e.Message);
        }
        Console.WriteLine("Last Statement.");
    }
}