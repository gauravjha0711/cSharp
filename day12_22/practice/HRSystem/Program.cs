using System;
public class Program
{
    public static void Main()
    {
        HRsystem hrSystem = new HRsystem();  //calling default constructor
        int emp1ID = 101;
        int emp2ID = 202;
        Console.WriteLine($"Before Swapping: emp1ID = {emp1ID}, emp2ID = {emp2ID}");
        hrSystem.swapref(ref emp1ID, ref emp2ID);
        Console.WriteLine($"After Swapping: emp1ID = {emp1ID}, emp2ID = {emp2ID}");
    }
}