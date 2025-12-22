using System;
using System.ComponentModel;
public class Program
{
    public static void Main()
    {
        Instance demo = new Instance();
        demo.var = 30;
        demo.Count();
        demo.Count();
        Console.WriteLine($"Instance Variable after increment: {demo.Display()}");

        Instance demoInstance2 = new Instance();
        demoInstance2.Count();
        Console.WriteLine($"Instance Variable of demoInstance2 after increment: {demoInstance2.Display()}"); 
        StaticInstance demo1 = new StaticInstance();
        // demo.var1 = 40;    //cannot access static variable by instance
        StaticInstance.var1 = 50;
        demo1.Count();
        demo1.Count();
        demo1.Count();
        Console.WriteLine($"Static Variable accessed by demo1 after increment: {demo1.Display()}");

        StaticInstance demo2 = new StaticInstance();
        demo2.Count();
        demo2.Count();
        demo2.Count();
        demo2.Count();
        Console.WriteLine($"Static Variable accessed by demo2 after increment: {demo2.Display()}");
    }
}