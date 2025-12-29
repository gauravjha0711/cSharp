using System;
using System.Reflection.PortableExecutable;
class Program
{
    public static void Main()
    {
        // int[] arr;
        // arr = new int[6];
        // arr[0] = 10;
        // arr[1] = 20;
        // arr[2] = 30;
        // arr[3] = 40;
        // arr[4] = 50;
        // arr[5] = 60;
        // int length = arr.Length;

        // Console.WriteLine($"Enter length of Array : ");
        // int length = Convert.ToInt32(Console.ReadLine());
        // arr = new int[length];
        // Console.WriteLine("Enter Array Element: ");
        // for(int i = 0; i < length; i++)
        // {
        //     Console.Write($"Enter Element for {i} index :");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine($"Lenght of Array : {length}");
        // for(int i = 0; i < length; i++)
        // {
        //     Console.WriteLine($"Element at {i} index is {arr[i]}");
        // }
        // Console.WriteLine("For Each :");
        // foreach(int i in arr)
        // {
        //     Console.WriteLine($"Element is {i}");
        // }

        // char[] ch = new char[]{'G','a','u','r','a','v','\0'};
        // char[] ch1 = new char[6];
        // Console.WriteLine("Enter Character: ");
        // for(int i = 0; i < ch1.Length; i++)
        // {
        //     ch1[i] = Convert.ToChar(Console.ReadLine());
        // }
        // Console.WriteLine("Character Array : ");
        // for(int i = 0; i < ch1.Length; i++)
        // {
        //     Console.WriteLine($"Char at {i} index is {ch1[i]}");
        // }

        string[] empNames = new string[6];
        Console.WriteLine("Enter Employee Name: ");
        for(int i = 0; i < empNames.Length; i++)
        {
            empNames[i] = Console.ReadLine();
        }
        Console.WriteLine("Employee Name: ");
        for(int i = 0; i < empNames.Length; i++)
        {
            Console.WriteLine($"Employee at {i} index is {empNames[i]}");
        }
    }
}