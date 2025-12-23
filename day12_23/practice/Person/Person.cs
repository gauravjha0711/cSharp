using System;
public class Person
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string Address { get; set; }
    public Person(string Name, int Age, string Address)
    {
        this.Name = Name;
        this.Age = Age;
        this.Address = Address;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Person's Informations: ");
        Console.WriteLine($"Name: {Name},\nAge: {Age},\nAddress: {Address}");
    }
}