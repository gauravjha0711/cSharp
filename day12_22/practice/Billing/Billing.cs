using System;
public class Billing
{
    
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }
    public Billing()  // Default Constructor
    {
        Number1 = 0;
        Number2 = 0;
        Result = 0;
    }
    public Billing(int Number1, int Number2)  // Parameterized Constructor
    {
        this.Number1 = Number1;
        this.Number2 = Number2;
        Result = 0;
    }
    
}