using System;
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string Make, string Model, int Year)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details: ");
        Console.WriteLine($"Make: {Make},\n Model: {Model},\n Year: {Year}");
    }
    public void DisplayAge()
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - Year;
        Console.WriteLine($"Car age is: {age}");
    }
}