using System;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string input1 = Console.ReadLine();
            string[] arr1 = input1.Split(' ');
            int[] numbers1 = Array.ConvertAll(arr1, int.Parse);
            string input2 = Console.ReadLine();
            string[] arr2 = input2.Split(' ');
            int[] numbers2 = Array.ConvertAll(arr2, int.Parse);

            if (numbers1.Length != numbers2.Length)
            {
                Console.WriteLine("Error: Arrays must have the same length for addition.");
                return;
            }

            int[] sumArray = new int[numbers1.Length];
            for (int i = 0; i < numbers1.Length; i++)
            {
                sumArray[i] = numbers1[i] + numbers2[i];
            }

            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Element at index {index} in the sum array: {sumArray[index]}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format. Please enter integers only.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of range for the sum array.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
    }
}
