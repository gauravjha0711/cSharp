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

        // string[] empNames = new string[6];
        // Console.WriteLine("Enter Employee Name: ");
        // for(int i = 0; i < empNames.Length; i++)
        // {
        //     empNames[i] = Console.ReadLine();
        // }
        // Console.WriteLine("Employee Name: ");
        // for(int i = 0; i < empNames.Length; i++)
        // {
        //     Console.WriteLine($"Employee at {i} index is {empNames[i]}");
        // }

        // Program program = new Program();
        // int[] arr = {10,20,30,40,50,60};
        // program.PassArrayDemo(arr);
        // int[] arr1 = program.ReturnArrayDemo(6);
        // Console.WriteLine($"Element Return from array are: ");
        // for(int i = 0; i < arr1.Length; i++)
        // {
        //     Console.WriteLine($"Element at {i} : {arr1[i]}");
        // }

        //2d array
        // int[,] arr = new int[3,3];
        // arr[0,0] = 10;
        // arr[0,1] = 20;
        // arr[0,2] = 30;
        // arr[1,0] = 40;
        // arr[1,1] = 50;
        // arr[1,2] = 60;
        // arr[2,0] = 70;
        // arr[2,1] = 80;
        // arr[2,2] = 90;
        // Console.WriteLine("Element in 3*3 Matrix is:");
        // for(int i = 0; i < arr.GetLength(0); i++)
        // {
        //     for(int j = 0; j < arr.GetLength(1); j++)
        //     {
        //         Console.Write($"{arr[i,j]} ");
        //     }
        //     Console.WriteLine();
        // }

        Console.Write("Enter Number of row: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of Column: ");
        int l = Convert.ToInt32(Console.ReadLine());
        int[,] arr1 = new int[k,l];
        Console.WriteLine("Enter element for matrxi: ");
        for(int i = 0; i < k; i++)
        {
            for(int j = 0; j < l; j++)
            {
                Console.Write($"Enter Element {i} row and {j} Column: ");
                arr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix of {k}*{l} are")
        for(int i = 0; i <k; i++)
        {
            for(int j = 0; j <l; j++)
            {
                Console.Write($"{arr1[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    public void PassArrayDemo(int[] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=arr[i];
        }
        Console.WriteLine($"Sum of all array is {sum}");
    }
    public int[] ReturnArrayDemo(int length)
    {
        int[] arr = new int[length];
        Console.WriteLine($"Enter {length} number od Element: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter element at {i}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
}