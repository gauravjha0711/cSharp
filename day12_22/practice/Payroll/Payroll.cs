using System;
public class Payroll
{
    public void swap(int salary1, int salary2)
    {
        int temp = salary1;
        salary1 = salary2;
        salary2 = temp;
        Console.WriteLine($"Inside swap method: salary1 = {salary1}, salary2 = {salary2}");
    }
}