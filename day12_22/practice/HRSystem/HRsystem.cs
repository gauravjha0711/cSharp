using System;
public class HRsystem
{
    public void swapref(ref int emp1ID, ref int emp2ID)
    {
        int temp = emp1ID;
        emp1ID = emp2ID;
        emp2ID = temp;
        Console.WriteLine($"Inside swapref method: emp1ID = {emp1ID}, emp2ID = {emp2ID}");
    }
}