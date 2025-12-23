using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Address: ");
        string address = Console.ReadLine();
        Person person1 = new Person(name, age, address);
        person1.DisplayDetails();
    }
}