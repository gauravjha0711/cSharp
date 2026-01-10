using System;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {   
            Console.WriteLine("Enter number of tickets:");
            int numberOfTickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per ticket:");
            decimal pricePerTicket = decimal.Parse(Console.ReadLine());

            if (numberOfTickets <= 0)
            {
                throw new ArgumentException("Number of tickets must be greater than 0.");
            }

            if (pricePerTicket <= 0)
            {
                throw new ArgumentException("Price per ticket must be greater than 0.");
            }

            decimal totalCost = numberOfTickets * pricePerTicket;
            Console.WriteLine($"Total ticket cost: {totalCost}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
