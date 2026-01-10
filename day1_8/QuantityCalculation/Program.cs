using System;
public class InvalidPriceException : Exception
{
    public InvalidPriceException(string message) : base(message)
    {
    }
}
public class InvalidQuantityException : Exception
{
    public InvalidQuantityException(string message) : base(message)
    {
    }
}
public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            if(price <= 0)
            {
                throw new InvalidPriceException("Price must be greater than zero.");
            }
            if(quantity <= 0)
            {
                throw new InvalidQuantityException("Quantity must be greater than zero.");
            }
            decimal TotalCost = price * quantity;
            Console.WriteLine($"Total Cost: {TotalCost}");
        }
        catch (InvalidPriceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch( InvalidQuantityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}