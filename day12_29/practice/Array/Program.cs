using System;
public class Program
{
    public static void Main()
    {
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.Write("Elements in the array are: ");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write(numbers[i] + " ");
        // }


        //reverse array
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The Original array is:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The Reversed array is:");
        int left=0;
        int right=size-1;
        while(left<right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
            left++;
            right--;
        }
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}