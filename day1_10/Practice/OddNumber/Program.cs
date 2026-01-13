using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number space separated:");
        string input = Console.ReadLine();
        List<int> number = ParseIntegers(input);
        List<int> oddNumbers = GetOddNumbers(number);
        Console.WriteLine("Odd Numbers: " + string.Join(" ", oddNumbers));
    }
    public static List<int> ParseIntegers(string input)
    {
        string[] parts = input.Split(' ');
        List<int> numbers = new List<int>();
        foreach (string part in parts)
        {
            if(int.TryParse(part,out int num))
            {
                numbers.Add(num);
            }
        }
        return numbers;
    }
    public static List<int> GetOddNumbers(List<int> numbers)
    {
        List<int> oddNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                oddNumbers.Add(number);
            }
        }
        oddNumbers.Sort();
        return oddNumbers;
    }
}