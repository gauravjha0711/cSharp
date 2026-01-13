using System;
public class Program
{
    public static void Main()
    {
        HashSet<string> stringSet = new HashSet<string>();
        while (true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. Add String (Add a new string)");
            Console.WriteLine("2. Display Strings (Display all strings)");
            Console.WriteLine("3. Update String (Update an existing string)");
            Console.WriteLine("4. Delete String (Remove a string)");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    AddString(stringSet);
                    break;
                case 2:
                    DisplayStrings(stringSet);
                    break;
                case 3:
                    UpdateString(stringSet);
                    break;
                case 4:
                    DeleteString(stringSet);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public static void AddString(HashSet<string> stringSet)
    {
        Console.Write("Enter a string to add: ");
        string input = Console.ReadLine();
        if (stringSet.Add(input))
        {
            Console.WriteLine("String added successfully.");
        }
        else
        {
            Console.WriteLine("String already exists in the set.");
        }
    }
    public static void DisplayStrings(HashSet<string> stringSet)
    {
        Console.WriteLine("Strings in the set:");
        foreach (var str in stringSet)
        {
            Console.WriteLine(str);
        }
    }
    public static void UpdateString(HashSet<string> stringSet)
    {
        Console.Write("Enter the string to update: ");
        string oldString = Console.ReadLine();
        if (stringSet.Contains(oldString))
        {
            Console.Write("Enter the new string: ");
            string newString = Console.ReadLine();
            stringSet.Remove(oldString);
            stringSet.Add(newString);
            Console.WriteLine("String updated successfully.");
        }
        else
        {
            Console.WriteLine("String not found in the set.");
        }
    }
    public static void DeleteString(HashSet<string> stringSet)
    {
        Console.Write("Enter the string to delete: ");
        string input = Console.ReadLine();
        if (stringSet.Remove(input))
        {
            Console.WriteLine("String deleted successfully.");
        }
        else
        {
            Console.WriteLine("String not found in the set.");
        }
    }
    
}