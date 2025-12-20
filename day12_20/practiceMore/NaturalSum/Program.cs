using System;
public class Program
{
    public static void Main()
    {
        //Natural number Sum Program
        Console.WriteLine("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num < 1)
        {
            Console.WriteLine("Please enter a positive integer greater than zero.");
        }
        else
        {
            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of natural numbers up to {num} is: {sum}");
        }
    }
}