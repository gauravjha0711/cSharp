using System;
public class Program
{
    public static void Main()
    {
        Action<string> printReversedString = str =>
        {
            string reversed = ReverseString(str);
            Console.WriteLine("Reversed String: " + reversed);
        };
        Func<string, bool> isPalindrome = str =>
        {
            string reversed = ReverseString(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        };
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.Write("Enter operation (reverse/palindrome): ");
        string operation = Console.ReadLine().ToLower();
        if(operation == "reverse")
        {
            printReversedString(input);
        }
        else if(operation == "palindrome")
        {
            bool result = isPalindrome(input);
            Console.WriteLine(result ? "The string is a palindrome." : "The string is not a palindrome.");
        }
        else
        {
            Console.WriteLine("Invalid operation selected.");
        }
    }
    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}