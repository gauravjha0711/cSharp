using System;
public class Program
{
    public static void Main()
    {
        string fname, lname;
        fname = "Gaurav";
        lname = "Jha";
        char[] letters = {'H','e','l','l','o'};
        string[] sarray = { "Hello","From","Gaurav","Jha"};
        string fullname = fname + " " + lname;
        Console.WriteLine($"FullName : {fullname}");

        string greeting = new string(letters);
        Console.WriteLine($"Greeting : {greeting}");

        string message = String.Join(" ", sarray);
        Console.WriteLine($"Message : {message}");

        DateTime waiting = new DateTime(2024, 12, 31, 23, 59, 59);
        string chat = String.Format("Message sent on {0:dd/MM/yyyy} at {0:HH:mm:ss}", waiting);
        Console.WriteLine($"Chat : {chat}");

        string str1 = "This is test";
        string str2 = "This is text";
        if(String.Compare(str1, str2) == 0)
        {
            Console.WriteLine("Strings are equal");
        }
        else
        {
            Console.WriteLine("Strings are not equal");
        }

        if(str1.Contains("test"))
        {
            Console.WriteLine("str1 contains 'test'");
        }
        else
        {
            Console.WriteLine("str1 does not contain 'test'");
        }
    }
}