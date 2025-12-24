using System;
public class Chair : Furniture
{
    public override void Accept()
    {
        Console.WriteLine("Enter Number of chair: :");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Color of chair: :");
        color = Console.ReadLine();
        Console.WriteLine("Enter Width of chair: :");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Height of chair: :");
        height = Convert.ToInt32(Console.ReadLine());
    }
    public override void Display()
    {
        Console.WriteLine($"Number of chair: {num}");
        Console.WriteLine($"Color of chair: {color}");
        Console.WriteLine($"Width of chair: {width}");
        Console.WriteLine($"Height of chair: {height}");
    }
}