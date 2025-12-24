using System;
public class Program
{
    public static void Main()
    {
        
        UnitConverter converter = null;
        Console.WriteLine("Unit Converter");
        Console.WriteLine("1. Length Converter");
        Console.WriteLine("2. Weight Converter");
        Console.WriteLine("3. Temperature Converter");
        Console.Write("Select an option (1, 2, or 3): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                converter = new LengthConversion();
                break;
            case 2:
                converter = new WeightConversion();
                break;
            case 3:
                converter = new TemperatureConversion();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        Console.Write("Enter value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter from unit: ");
        string fromUnit = Console.ReadLine();
        Console.Write("Enter to unit (or press Enter for default): ");
        string toUnit = Console.ReadLine();
        double result;
        if (string.IsNullOrEmpty(toUnit))
        {
            result = converter.Convert(value, fromUnit);
        }
        else
        {
            result = converter.Convert(value, fromUnit, toUnit);
        }
        Console.WriteLine($"Converted value: {result}");

    }
    
}