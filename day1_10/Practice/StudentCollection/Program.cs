using System;
using System.Collections;
using System.Text;
public class Program
{
    public static void Main()
    {
        ArrayList students = new ArrayList();
        StringBuilder ans = new StringBuilder();
        while (true)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            if (name.ToLower().Equals("stop"))
            {
                break;
            }
            if (!isValidName(name))
            {
                continue;
            }
            if (isDuplicate(students,name))
            {
                ans.AppendLine($"{name} is already in the collection.");
            }
            else
            {
                students.Add(name);
                ans.AppendLine($"{name} added to the collection.");
            }
        }
        Console.WriteLine(ans.ToString());
        Console.WriteLine("Unique Students name entered: ");
        DisplayStudentNames(students);
    }
    private static bool isValidName(string name)
    {
        return !string.IsNullOrWhiteSpace(name);
    }
    private static bool isDuplicate(ArrayList students, string name)
    {
        foreach (object item in students)
        {
            if (item.ToString().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
    private static void DisplayStudentNames(ArrayList students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}