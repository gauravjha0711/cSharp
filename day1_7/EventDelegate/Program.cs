using System;
public class Program
{
    private static int result;
    public static bool IsApple(string str)
    {
        return str.Equals("I Phone X");
    }
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }
    public static void Main()
    {
        // AddTwoNumber a = new AddTwoNumber();
        // a.ev_OddNumber += new AddTwoNumber.dg_OddNumber(EventMessage); //subscribe event
        // a.Add();


        //func delegate
        // Func<int, int, int> Addition = AddNumbers;
        // System.Console.WriteLine("Sum: " + Addition(10, 20));


        //action delegate
        // Action<int,int> Addition = AddNumbers;
        // Console.WriteLine("Sum: " + Addition(10, 20));


        //predicate delegate
        Predicate<string> checkIfApple = IsApple;
        bool result = checkIfApple("I Phone X");
        if(result)
            Console.WriteLine("It's an I Phone X");
    }
    public static void EventMessage()
    {
        Console.WriteLine("Event Executed: "+"This is an odd number");
    }
}