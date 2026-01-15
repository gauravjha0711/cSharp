using System;
[DeBugInfo(1, "Alice Smith", "10/8/2024", Message = "Initial Implementation")]
[DeBugInfo(2, "Bob Johnson", "11/8/2024", Message = "Optimized GetArea method")]
class Rectangle
{
    private double Length;
    private double Width;
    public Rectangle(double l, double w)
    {
        Length = l;
        Width = w;
    }
    [DeBugInfo(45, "Arun", "12/8/2024",Message = "Return type mismatch")]
    public double GetArea()
    {
        return Length * Width;
    }
    [DeBugInfo(49, "Gaurav", "15/8/2024")]
    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Width: {Width}, Area: {GetArea()}");
    }
}