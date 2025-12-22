using System;
public class Program
{
    public static void Main()
    {
        Payroll payroll = new Payroll();  //calling default constructor
        int salary1 = 5000;
        int salary2 = 7000;
        Console.WriteLine($"Before Swapping: salary1 = {salary1}, salary2 = {salary2}");
        payroll.swap(salary1, salary2);
        Console.WriteLine($"After Swapping: salary1 = {salary1}, salary2 = {salary2}");
    }
}