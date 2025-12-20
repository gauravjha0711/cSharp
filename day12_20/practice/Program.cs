using System;
public class Program
{
    public static void Main()
    {
        // Employee emp = new Employee();
        // emp.AcceptDetails();
        // emp.CalculateSalaries();
        // emp.DisplayDetails();
        // Console.ReadKey(); // To keep the console window open


        Student stu = new Student();
        stu.StuNum = 1;
        stu.StuName = "Gaurav Jha";
        stu.Marks = new float[] { 85.5f, 90.0f, 78.5f, 88.0f, 92.5f, 80.0f };
        // stu.AcceptDetails();
        stu.CalculateResults();
        stu.DisplayResults();
    }
}