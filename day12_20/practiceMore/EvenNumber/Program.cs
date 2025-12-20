using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Number of Even Numbers to Display: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"First {n} Even Numbers are: ");
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i * 2);
        }
    }
}