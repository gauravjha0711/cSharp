using System;
using System.Text.RegularExpressions;
public class Shipment
{
    public string ShipmentCode { get; set; }
    public string TransportMode { get; set; }
    public double Weight { get; set; }
    public int StorageDates { get; set; }
}
public class ShipmentDetails : Shipment
{
    public bool ValidateShipmentCode()
    {
        string pattern = @"^GC#\d{4}$";
        return Regex.IsMatch(ShipmentCode, pattern);
    }
    public double CalculateTotalCost()
    {
        //$TotalCost = (Weight \times RatePerKg) + \sqrt{StorageDays}$
        double ratePerKg = 0;
        if(TransportMode=="Air")
        {
            ratePerKg = 50;
        }
        else if(TransportMode=="Sea")
        {
            ratePerKg = 15;
        }
        else if(TransportMode=="Land")
        {
            ratePerKg = 25;
        }
        return Math.Round((Weight * ratePerKg) + Math.Sqrt(StorageDates), 2);
    }
}
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Shipment Code: ");
        string ShipmentCode = Console.ReadLine();
        ShipmentDetails shipment = new ShipmentDetails()
        {
            ShipmentCode = ShipmentCode
        };
        if(!shipment.ValidateShipmentCode())
        {
            Console.WriteLine("Invalid Shipment Code");
            return;
        }
        Console.Write("Enter Transport Mode (Air/Sea/Land): ");
        string TransportMode = Console.ReadLine();
        Console.Write("Enter Weight (in kg): ");
        double Weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Storage Dates: ");
        int StorageDates = Convert.ToInt32(Console.ReadLine());
        shipment.TransportMode = TransportMode;
        shipment.Weight = Weight;
        shipment.StorageDates = StorageDates;
        double totalCost = shipment.CalculateTotalCost();
        Console.WriteLine($"Total Shipping Cost is: {totalCost}");
    }
}