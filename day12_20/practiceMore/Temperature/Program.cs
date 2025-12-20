using System;
public class Program
{
    //Temperature Conversion Program from Celsius to Fahrenheit
    static void Main()
    {
        Console.WriteLine("Enter Temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Celsius: {celsius}°C");
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
    }
}