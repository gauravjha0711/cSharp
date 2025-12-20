using System;
class Program
{
    //Leap Year Program
    static void Main()
    {
        Console.WriteLine("Enter a Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if((year%4==0 && year%100!=0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year");
        }
    }
}