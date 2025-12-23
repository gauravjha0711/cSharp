using System;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Car Make: ");
        string make = Console.ReadLine();
        Console.WriteLine("Enter Car Model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Enter Car Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Car car1 = new Car(make, model, year);
        car1.DisplayDetails();
        car1.DisplayAge();
    }
}