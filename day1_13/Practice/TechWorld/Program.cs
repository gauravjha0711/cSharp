using System;
public class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicsCard { get; set; }
    
}
public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }
    public double DesktopPriceCalculation()
    {
        double price = 0;
        if (Processor == "i3")
        {
            price += 1500;
        }
        else if (Processor == "i5")
        {
            price += 3000;
        }
        else if (Processor == "i7")
        {
            price += 4500;
        }
        price += RamSize * 200;
        price += HardDiskSize * 1500;
        price += GraphicsCard * 2500;
        price += PowerSupplyVolt * 20;
        price += MonitorSize * 250;
        return price;
    }
}
public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }
    public double LaptopPriceCalculation()
    {
        double price = 0;
        if (Processor == "i3")
        {
            price += 2500;
        }
        else if (Processor == "i5")
        {
            price += 5000;
        }
        else if (Processor == "i7")
        {
            price += 6500;
        }
        price += RamSize * 200;
        price += HardDiskSize * 1500;
        price += GraphicsCard * 2500;
        price += BatteryVolt * 20;
        price += DisplaySize * 250;
        return price;
    }
}
public class Program
{
    public static void Main()
    {
        Console.Write("System type (Laptop/Desktop): ");
        string systemType = Console.ReadLine();
        if (systemType == "Desktop")
        {
            Desktop desktop = new Desktop();
            Console.Write("Enter Processor Type: ");
            desktop.Processor = Console.ReadLine();
            Console.Write("Enter RAM Size (in GB): ");
            desktop.RamSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hard Disk Size (in GB): ");
            desktop.HardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Graphics Card Size (in GB): ");
            desktop.GraphicsCard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Monitor Size (in inches): ");
            desktop.MonitorSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Power Supply Volt (in V): ");
            desktop.PowerSupplyVolt = Convert.ToInt32(Console.ReadLine());
            double desktopPrice = desktop.DesktopPriceCalculation();
            Console.WriteLine("Total Desktop Price: " + desktopPrice);
        }
        else if (systemType == "Laptop")
        {
            Console.Write("Enter Processor Type: ");
            Laptop laptop = new Laptop();
            laptop.Processor = Console.ReadLine();
            Console.Write("Enter RAM Size (in GB): ");
            laptop.RamSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hard Disk Size (in GB): ");
            laptop.HardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Graphics Card Size (in GB): ");
            laptop.GraphicsCard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Display Size (in inches): ");
            laptop.DisplaySize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Battery Volt (in V): ");
            laptop.BatteryVolt = Convert.ToInt32(Console.ReadLine());
            double laptopPrice = laptop.LaptopPriceCalculation();
            Console.WriteLine("Total Laptop Price: " + laptopPrice);
        }
    }
}