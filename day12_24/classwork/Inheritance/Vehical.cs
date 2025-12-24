using System;
public class Vehical   //Base Class
{
    protected double distance = 0.0;
    protected double hours = 0.0;
    protected double fuel = 0.0;
    public Vehical(double distance, double hours, double fuel)
    {
        this.distance = distance;
        this.hours = hours;
        this.fuel = fuel;
    }
    public void Average()
    {
        double average = 0.0;
        average = distance / fuel;
        Console.WriteLine($"Average Fuel Consumption: {average} km/l");
    }
    public virtual void Speed()
    {
        double speed = 0.0;
        speed = distance / hours;
        Console.WriteLine($"Speed of Vehical: {speed} km/h");
    }
}