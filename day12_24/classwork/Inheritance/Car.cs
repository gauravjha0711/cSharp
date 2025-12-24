using System;
public class Car : Vehical  //Derived Class
{
    public Car(double distance, double hours, double fuel) : base(distance, hours, fuel)
    {
        
    }
    public new void Average()  //Method Hiding
    {
        double average = 0.0;
        average = (distance / fuel);
        Console.WriteLine($"Average Fuel Consumption of Car: {average} km/l");
    }
    public override void Speed()  //Method Overriding
    {
        double speed = 0.0;
        speed = (distance / hours);
        Console.WriteLine($"Speed of Car: {speed} km/h");
    }
}