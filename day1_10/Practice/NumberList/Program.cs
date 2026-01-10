using System;
using System.Collections;
using System.Text;

public class Program
{
    public static void Main()
    {
        ArrayList numbers = new ArrayList();
        StringBuilder ans = new StringBuilder();
        while (true)
        {
            Console.Write("Enter command (add, remove, display, exit): ");
            string command = Console.ReadLine().ToLower();
            if (command == "exit")
            {
                break;
            }
            else if (command == "add")
            {
                Console.Write("Enter number to add: ");
                string numberToAdd = Console.ReadLine();
                if(!IsDigit(numberToAdd))
                {
                    ans.AppendLine("Invalid number. Please enter a valid integer.");
                }
                else
                {
                    numbers.Add(int.Parse(numberToAdd));
                    ans.AppendLine($"{numberToAdd} added to the number list.");
                }
            }
            else if (command == "remove")
            {
                Console.Write("Enter number to remove: ");
                string numberToRemove = Console.ReadLine();
                if(!IsDigit(numberToRemove))
                {
                    ans.AppendLine("Invalid number. Please enter a valid integer.");
                }
                else
                {
                    int num = int.Parse(numberToRemove);
                    if (numbers.Contains(num))
                    {
                        numbers.Remove(num);
                        ans.AppendLine($"{numberToRemove} removed from the number list.");
                    }
                    else
                    {
                        ans.AppendLine($"{numberToRemove} not found in the number list.");
                    }
                }
            }
            else if (command == "display")
            {
                ans.AppendLine("Current numbers in the list:");
                foreach (var num in numbers)
                {
                    ans.AppendLine(num.ToString());
                }
            }
            else
            {
                ans.AppendLine("Unknown command.");
            }
        }
        Console.WriteLine(ans.ToString());
    }
    private static bool IsDigit(string value)
    {
        return int.TryParse(value, out _);
    }
}