using System;
class Program
{   
    int number1, number2, result;
    public static void Main()
    {
        Program calc = new Program();
        Console.WriteLine("Select an operation to perform : ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                calc.Add();
                break;
            case 2:
                calc.Subtract();
                break;
            case 3:
                calc.Multiply();
                break;
            case 4:
                calc.Divide();
                break;
            case 5:
                calc.Modulus();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
    public void Add()
    {
        Console.WriteLine("Enter First Number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Number2: ");
        number2 =  Convert.ToInt32(Console.ReadLine());
        result = number1+number2;
        Console.WriteLine($"Sum of number {number1} and {number2} is {result}");
    }
    public void Subtract()
    {
        Console.WriteLine("Enter First Number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Number2: ");
        number2 =  Convert.ToInt32(Console.ReadLine());
        result = number1-number2;
        Console.WriteLine($"Subtract of number {number1} and {number2} is {result}");
    }
    public void Multiply()
    {
        Console.WriteLine("Enter First Number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Number2: ");
        number2 =  Convert.ToInt32(Console.ReadLine());
        result = number1*number2;
        Console.WriteLine($"Multiply of number {number1} and {number2} is {result}");
    }
    public void Divide()
    {
        Console.WriteLine("Enter First Number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Number2: ");
        number2 =  Convert.ToInt32(Console.ReadLine());
        result = number1/number2;
        Console.WriteLine($"Divide of number {number1} and {number2} is {result}");
    }
    public void Modulus()
    {
        Console.WriteLine("Enter First Number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Number2: ");
        number2 =  Convert.ToInt32(Console.ReadLine());
        result = number1%number2;
        Console.WriteLine($"Modulus of number {number1} and {number2} is {result}");
    }
}