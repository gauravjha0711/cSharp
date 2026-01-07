using System;
public class Program
{
    public static void Main()
    {
        AddTwoNumber a = new AddTwoNumber();
        a.ev_OddNumber += new AddTwoNumber.dg_OddNumber(EventMessage); //subscribe event
        a.Add();
    }
    public static void EventMessage()
    {
        Console.WriteLine("Event Executed: "+"This is an odd number");
    }
}