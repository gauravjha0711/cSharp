using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter numbers space separated: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        List<int> numbers = new List<int>();
        foreach(string part in parts)
        {
            if(int.TryParse(part,out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine($"'{part}' is not a valid integer");
                return;
            }
        }
        List<int> squaredNumbers = new List<int>();
        foreach(int number in numbers)
        {
            squaredNumbers.Add(number * number);
        }
        //descending order
        squaredNumbers.Sort((a,b)=>b.CompareTo(a));
        Console.WriteLine("Sorted Squared Numbers: "+string.Join(" ",squaredNumbers));
    }
}