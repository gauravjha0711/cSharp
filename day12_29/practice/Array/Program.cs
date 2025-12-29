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
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.WriteLine("The Original array is:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write(numbers[i] + " ");
        // }
        // Console.WriteLine();
        // Console.WriteLine("The Reversed array is:");
        // int left=0;
        // int right=size-1;
        // while(left<right)
        // {
        //     int temp = numbers[left];
        //     numbers[left] = numbers[right];
        //     numbers[right] = temp;
        //     left++;
        //     right--;
        // }
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write(numbers[i] + " ");
        // }


        //Sum of array elements
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // int sum = 0;
        // for (int i = 0; i < size; i++)
        // {
        //     sum += numbers[i];
        // }
        // Console.WriteLine($"Sum of all array elements is: {sum}");


        //Copy one array to another array
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // int[] copyArray = new int[size];
        // for (int i = 0; i < size; i++)
        // {
        //     copyArray[i] = numbers[i];
        // }
        // Console.WriteLine("Elements in original array are: ");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write(numbers[i] + " ");
        // }
        // Console.WriteLine("\nElements in copied array are: ");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write(copyArray[i] + " ");
        // }


        //count total duplicate elements in array
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // int duplicateCount = 0;
        // for (int i = 0; i < size; i++)
        // {
        //     for (int j = i + 1; j < size; j++)
        //     {
        //         if (numbers[i] == numbers[j])
        //         {
        //             duplicateCount++;
        //             break;
        //         }
        //     }
        // }
        // Console.WriteLine($"Total duplicate elements in the array: {duplicateCount}");


        //print all unique elements in array
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Unique elements in the array are:");
        for (int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                if(i!=j && numbers[i]==numbers[j])
                {
                    break;
                }
                else if(j==size-1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}