using System;
public class Bookshelve : Furniture{
    public override void Accept()
    {
        Console.WriteLine("Enter Number of shelve: :");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Color of shelve: :");
        color = Console.ReadLine();
        Console.WriteLine("Enter Width of shelve: :");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Height of shelve: :");
        height = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.WriteLine($"Number of shelve: {num}");
        Console.WriteLine($"Color of shelve: {color}");
        Console.WriteLine($"Width of shelve: {width}");
        Console.WriteLine($"Height of shelve: {height}");
    }
}