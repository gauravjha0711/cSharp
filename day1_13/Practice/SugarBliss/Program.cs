using System;
public class Chocolate
{
    public string Flavor { get; set; }
    public int Quantity { get; set; }
    public int PricePerUnit { get; set; }
    public double TotalPrice { get; set; }
    public double DiscountedPrice { get; set; }
    public bool ValidateChocolateFlavour()
    {
        if(Flavor=="Dark" || Flavor=="Milk" || Flavor=="White")
        {
            return true;
        }
        return false;
    }
    public void CalculateDiscountedPrice()
    {
        if (Flavor == "Dark")
        {
            TotalPrice = Quantity * PricePerUnit;
            DiscountedPrice = TotalPrice - (0.18 * TotalPrice);
        }
        else if (Flavor == "Milk")
        {
            TotalPrice = Quantity * PricePerUnit;
            DiscountedPrice = TotalPrice - (0.12 * TotalPrice);
        }
        else if (Flavor == "White")
        {
            TotalPrice = Quantity * PricePerUnit;
            DiscountedPrice = TotalPrice - (0.06 * TotalPrice);
        }
    }
    public void DisplyayDetails()
    {
        Console.WriteLine("Flavor: " + Flavor);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Price per Unit: " + PricePerUnit);
        Console.WriteLine("Total Price: " + TotalPrice);
        Console.WriteLine("Discounted Price: " + DiscountedPrice);
    }
}
public class Program
{
    public static void Main()
    {
        Chocolate chocolate = new Chocolate();
        Console.Write("Enter Chocolate Flavor (Dark/Milk/White): ");
        chocolate.Flavor = Console.ReadLine();
        Console.Write("Enter Quantity: ");
        chocolate.Quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Price per Unit: ");
        chocolate.PricePerUnit = Convert.ToInt32(Console.ReadLine());
        if(!chocolate.ValidateChocolateFlavour())
        {
            Console.WriteLine("Invalid Chocolate Flavor");
            return;
        }
        chocolate.CalculateDiscountedPrice();
        chocolate.DisplyayDetails();
    }
}