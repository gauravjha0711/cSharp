using System;
class Program
{
    public static void Main()
    {
        // Create an instance of Employee class
        // Employee employee = new Employee();
        // employee.AcceptDetails();
        // employee.DisplayDetails();

        Employee employee1 = new Employee();
        employee1.EmpId = 101;
        employee1.Name = "Gaurav Jha";
        employee1.Department = "IT";
        employee1.Salary = 75000.0f;
        employee1.Status = true;
        employee1.DisplayDetails();
        Console.ReadKey();  // To keep the console window open
    }
}