using System;
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

        System.Console.WriteLine($"Employee Object: {employee}");


    }
}