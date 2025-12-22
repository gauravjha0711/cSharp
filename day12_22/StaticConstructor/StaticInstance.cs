using System;
public class StaticInstance
{
    public static int var1 = 10;
    public void Count()
    {
        var1++;
    }
    public int Display()
    {
        return var1;
    }
}