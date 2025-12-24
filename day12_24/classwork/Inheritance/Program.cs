using System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main()
    {
        // object initialization syntax
        Employee employee = new Employee
        {
            EmployeeID = 101,
            Name = "John Doe",
            Salary = 50000.0f
        };
        // Console.WriteLine("Employee Details:");
        // Console.WriteLine($"Employee ID: {employee.EmployeeID}");
        // Console.WriteLine($"Employee Name: {employee.Name}");
        // Console.WriteLine($"Employee Salary: {employee.Salary}");

        // System.Console.WriteLine($"Employee Object: {employee}");

        // Program program = new Program();
        // // program.Add(10, 20);
        // int[] arr = { 1, 2, 3, 4, 5 };
        // program.Add(arr);


        Calculator calculator = new Calculator();
        Console.WriteLine("Add with no parameters: " + calculator.Add());
        Console.WriteLine("Add with two integers: " + calculator.Add(15, 25));
        Console.WriteLine("Add with two strings: " + calculator.Add("Hello, ", "World!"));
        Console.WriteLine("Add with two floats: " + calculator.Add(10.5f, 20.3f));
        

    }
    public void Add(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine($"Sum: {sum}");
    }
    public void Add(params int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of Array: {sum}");
    }
}