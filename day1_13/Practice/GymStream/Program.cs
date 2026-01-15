using System;
class InvalidTierException : Exception
{
    public InvalidTierException(string message) : base(message) { }
}
class ArgumentException : Exception
{
    public ArgumentException(string message) : base(message) { }
}
public class Program
{
    public static void Main()
    {
        MemeberShip memeberShip = new MemeberShip();
        Console.Write("Enter Membership Tier (Basic/Premium/Elite): ");
        memeberShip.Tier = Console.ReadLine();
        Console.Write("Enter Duration in Months: ");
        memeberShip.DurationInMonths = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Base Price per Month: ");
        memeberShip.BasePricePerMonth = Convert.ToDouble(Console.ReadLine());
        try
        {
            if (memeberShip.ValidateEnrollment())
            {
                double totalBill = memeberShip.CalculateTotalBill();
                Console.WriteLine("Total Bill after discounts: " + totalBill);
            }
        }
        catch (InvalidTierException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
public class MemeberShip
{
    public string Tier { get; set; }
    public int DurationInMonths { get; set; }
    public double BasePricePerMonth { get; set; }
    public bool ValidateEnrollment()
    {
        if( Tier!="Basic" && Tier!="Premium" && Tier!="Elite")
        {
            throw new InvalidTierException("Invalid membership tier selected.");
        }
        if( DurationInMonths <1)
        {
            throw new ArgumentException("Duration must be at least 1 month.");
        }
        return true;
    }
    public double CalculateTotalBill()
    {
        double total = BasePricePerMonth * DurationInMonths;
        int basicDiscount = 2;
        int premiumDiscount = 7;
        int eliteDiscount = 12;
        if(Tier=="Basic") total = ((100-basicDiscount)/100.0)*total;
        else if(Tier=="Premium") total = ((100-premiumDiscount)/100.0)*total;
        else if(Tier=="Elite") total = ((100-eliteDiscount)/100.0)*total;
        return total;
    }
}