using System;
public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Choose conversion type: 1. Uppercase 2. Lowercase 3. Title Case");
        int choice = Convert.ToInt32(Console.ReadLine());
        string result = string.Empty;
        switch (choice)
        {
            case 1:
                result = program.ConvertString(input);
                break;
            case 2:
                result = program.ConvertString(input, true);
                break;
            case 3:
                result = program.ConvertString(input, 1);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        Console.WriteLine("Converted string: " + result);
    }
    public string ConvertString(string input)
    {
        return input.ToUpper();
    }
    public string ConvertString(string input, bool toLower)
    {
        if (toLower)
        {
            return input.ToLower();
        }
        return input;
    }
    public string ConvertString(string input,int toTitleCase)
    {
        if(toTitleCase == 1)
        {
            string[] arr = input.Split(' ');
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i].Length > 0)
                {
                    arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1).ToLower();
                }
            }
            input = string.Join(" ", arr);
        }
        return input;
    }
}