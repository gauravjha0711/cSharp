using System;
public class Program
{
    public static void Main()
    {
        MyCollection obj = new MyCollection();
        foreach(var item in obj)
        {
            Console.WriteLine(item);
        }
    }
}