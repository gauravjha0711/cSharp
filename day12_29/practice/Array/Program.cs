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
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.Write("Unique elements in the array are:");
        // for (int i = 0; i < size; i++)
        // {
        //     for(int j = 0; j < size; j++)
        //     {
        //         if(i!=j && numbers[i]==numbers[j])
        //         {
        //             break;
        //         }
        //         else if(j==size-1)
        //         {
        //             Console.Write(numbers[i] + " ");
        //         }
        //     }
        // }



        //merge two sorted array
        // Console.Write("Enter size of first sorted array: ");
        // int size1 = Convert.ToInt32(Console.ReadLine());
        // int[] array1 = new int[size1];
        // Console.WriteLine("Enter elements of first sorted array:");
        // for (int i = 0; i < size1; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     array1[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.Write("Enter size of second sorted array: ");
        // int size2 = Convert.ToInt32(Console.ReadLine());
        // int[] array2 = new int[size2];
        // Console.WriteLine("Enter elements of second sorted array:");
        // for (int i = 0; i < size2; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     array2[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // int[] mergedArray = new int[size1 + size2];
        // int i1 = 0, i2 = 0, im = 0;
        // while (i1 < size1 && i2 < size2)
        // {
        //     if (array1[i1] < array2[i2])
        //     {
        //         mergedArray[im++] = array1[i1++];
        //     }
        //     else
        //     {
        //         mergedArray[im++] = array2[i2++];
        //     }
        // }
        // while (i1 < size1)
        // {
        //     mergedArray[im++] = array1[i1++];
        // }
        // while (i2 < size2)
        // {
        //     mergedArray[im++] = array2[i2++];
        // }
        // Console.WriteLine("Merged sorted array is:");
        // for (int i = 0; i < mergedArray.Length; i++)
        // {
        //     Console.Write(mergedArray[i] + " ");
        // }


        //count frequency of each element in array
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.WriteLine("Frequency of each element in the array:");
        // bool[] visited = new bool[size];
        // for (int i = 0; i < size; i++)
        // {
        //     if (visited[i])
        //     {
        //         continue;
        //     }
        //     int count = 1;
        //     for (int j = i + 1; j < size; j++)
        //     {
        //         if (numbers[i] == numbers[j])
        //         {
        //             count++;
        //             visited[j] = true;
        //         }
        //     }
        //     Console.WriteLine($"{numbers[i]} occurs {count} time(s)");
        // }



        //maximum and minimum element in array
        // Console.Write("Enter size of array: ");
        // int size = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[size];
        // Console.WriteLine("Enter array elements:");
        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Element {i}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // int max = numbers[0];
        // int min = numbers[0];
        // for (int i = 1; i < size; i++)
        // {
        //     if (numbers[i] > max)
        //     {
        //         max = numbers[i];
        //     }
        //     if (numbers[i] < min)
        //     {
        //         min = numbers[i];
        //     }
        // }
        // Console.WriteLine($"Maximum element is: {max}");
        // Console.WriteLine($"Minimum element is: {min}");


        //separate even and odd numbers in separate array
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int evenCount = 0;
        int oddCount = 0;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        int[] evenNumbers = new int[evenCount];
        int[] oddNumbers = new int[oddCount];
        int eIndex = 0;
        int oIndex = 0;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbers[eIndex++] = numbers[i];
            }
            else
            {
                oddNumbers[oIndex++] = numbers[i];
            }
        }
        Console.Write("Even numbers are: ");
        for (int i = 0; i < evenNumbers.Length; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Odd numbers are: ");
        for (int i = 0; i < oddNumbers.Length; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
    }
}