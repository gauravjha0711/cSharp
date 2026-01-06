using System;
public class MyException : Exception
{
    public MyException(string message)
    {
        Console.WriteLine("MyException: " + message);
    }
}