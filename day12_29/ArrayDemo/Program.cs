using System;
class Program
{
    public static void Main()
    {
        int[] arr;
        // arr = new int[6];
        // arr[0] = 10;
        // arr[1] = 20;
        // arr[2] = 30;
        // arr[3] = 40;
        // arr[4] = 50;
        // arr[5] = 60;
        // int length = arr.Length;

        Console.WriteLine($"Enter length of Array : ");
        int length = Convert.ToInt32(Console.ReadLine());
        arr = new int[length];
        Console.WriteLine("Enter Array Element: ");
        for(int i = 0; i < length; i++)
        {
            Console.Write($"Enter Element for {i} index :");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Lenght of Array : {length}");
        for(int i = 0; i < length; i++)
        {
            Console.WriteLine($"Element at {i} index is {arr[i]}");
        }
        Console.WriteLine("For Each :");
        foreach(int i in arr)
        {
            Console.WriteLine($"Element is {i}");
        }
    }
}