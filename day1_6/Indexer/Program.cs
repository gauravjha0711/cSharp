using System;
public class Indexer
{
    public static void Main()
    {
        Employee employee = new Employee();
        employee[0] = "String 1";
        employee[1] = "String 2";
        employee[2] = "String 3";
        employee[3] = "String 4";
        employee[4] = "String 5";

        // employee[5] = "String 6"; // This will throw an exception IndexOutOfRange
        Console.WriteLine("Accessing values using indexer:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(employee[i]);
        }

        Console.WriteLine($"Value at third index: {employee[2]}");
        Console.WriteLine($"The value 'String 4' is at index: {employee["String 4"]}");
    }
}