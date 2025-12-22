using System;
public class Calculator
{
    
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }
    public Calculator()  // Default Constructor
    {
        Number1 = 0;
        Number2 = 0;
        Result = 0;
    }
    public Calculator(int Number1, int Number2)  // Parameterized Constructor
    {
        this.Number1 = Number1;
        this.Number2 = Number2;
        Result = 0;
    }
    //Method with parameters and return type
    //Method withput parameters and return type
    //Method with parameters and without return type
    //Method without parameters and without return type

    //Method with parameters and return type
    public int Add(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = Number1 + Number2;
        return Result;   
    }
    //Method with parameters and without return type
    public void Subtract(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = Number1 - Number2;
        Console.WriteLine($"Substraction of {Number1} and {Number2} is: {Result}");
    }
    //Method without parameters and return type
    public int Multiply()
    {
        Result = Number1 * Number2;
        return Result;
    }
    //Method without parameters and without return type
    public void Divide()
    {
        Result = Number1 / Number2;
        Console.WriteLine($"Division of {Number1} and {Number2} is: {Result}");
    }

}