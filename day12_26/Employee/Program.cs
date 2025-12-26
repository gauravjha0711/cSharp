using System;
namespace PartialDemo
{
    public delegate int CalculatorDelegate(int num1, int num2);
    public class Program
    {
        public static void Main()
        {
            // PartialEmployee part = new PartialEmployee();
            // part.FirstName = "Gaurav";
            // part.LastName = "Jha";
            // part.Gender = "Male";
            // part.Salary = 45000.00;
            // part.DisplayFullName();
            // part.DisplayEmployeeDetails();
            // part.PartialMethod();

            Calculator calculator = new Calculator();
            CalculatorDelegate calcAdd = new CalculatorDelegate(calculator.Add);
            CalculatorDelegate calcSub = new CalculatorDelegate(calculator.Subtract);
            CalculatorDelegate calcMul = new CalculatorDelegate(calculator.Multiply);
            CalculatorDelegate calcDiv = new CalculatorDelegate(calculator.Divide);

            int num1 =20, num2 = 10;
            Console.WriteLine($"Addition: {calcAdd(num1, num2)}");
            Console.WriteLine($"Subtraction: {calcSub(num1, num2)}");
            Console.WriteLine($"Multiplication: {calcMul(num1, num2)}");
            Console.WriteLine($"Division: {calcDiv(num1, num2)}");
        }
    }
}