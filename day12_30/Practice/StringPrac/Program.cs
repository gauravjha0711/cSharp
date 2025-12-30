using System;
public class Program
{
    public static void Main()
    {
        // Console.WriteLine("Enter a string: ");
        // string temp = Console.ReadLine();
        // Console.WriteLine($"You enter: {temp}");

        string[] StringArray = new string[5];
        Console.WriteLine("Enter 5 string: ");
        for(int i = 0; i < 5; i++)
        {   
            Console.Write($"Enter String at index {i}: ");
            StringArray[i] = Console.ReadLine();
        }
        Console.WriteLine("All String are: ");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(StringArray[i]);
        }
    }
}