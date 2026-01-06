using System;
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Convert to (C/F): ");
            char scale = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            if(scale == 'C')
            {
                double fahrenheit = temp*9/5 + 32;
                Console.WriteLine($"Temperature in fahrenheit: {fahrenheit:F2} F");
            }
            else if(scale == 'F')
            {
                double celc = (temp - 32) * 5 / 9;
                Console.WriteLine($"Temperature in celsius: {celc:F2} C");
            }
            else
            {
                throw new TypeException("Please enter 'C' or 'F'.");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Invalid input provided.");
            Console.WriteLine("Exception Message: " + e.Message);
        }
        catch(TypeException e)
        {
            Console.WriteLine("Invalid Conversion Type. " + e.Message);
        }
    }
}