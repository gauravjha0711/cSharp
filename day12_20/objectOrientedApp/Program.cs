using System;
class Program
{
    public static void Main()
    {
        // Create an instance of Employee class
        Employee employee = new Employee();
        employee.AcceptDetails();
        employee.DisplayDetails();
        Console.ReadKey();  // To keep the console window open
    }
}