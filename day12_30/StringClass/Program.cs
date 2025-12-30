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
            Console.WriteLine($"Strings {str1} and {str2} are equal");
        }
        else
        {
            Console.WriteLine($"Strings {str1} and {str2} are not equal");
        }

        if(str1.Contains("test"))
        {
            Console.WriteLine($"str1 {str1} contains 'test'");
        }
        else
        {
            Console.WriteLine($"str1 {str1} does not contain 'test'");
        }

        string str3 = "Last night I dreamt of Mutton";
        Console.WriteLine($"Original String : {str3}");
        string substr = str3.Substring(11);
        Console.WriteLine($"Substring from index 11 : {substr}");

        //world print in next line
        Console.WriteLine("Hello\nWorld");

        Console.WriteLine("\"Gaurav Jha\"");

        Console.WriteLine(@"D:\\csharp\\day12_30\\StringClass\\Program.cs");

        var message1 = @"Helo Gaurav,
        Good Morning!
        Thanks,
        Admin";
        Console.WriteLine($"Message1: {message1}");

        var name = "Gaurav";
        var greeting1 = String.Format("Hello {0}", name, "Good Morning !");
        Console.WriteLine($"Combined: {greeting1}");

        var name2 = "Gaurav";
        var greet = "Good Morning";
        var greeting2 = $"Hello {name2}, {greet}!";
        Console.WriteLine($"Greeting2: {greeting2}");

        var num = 10;
        Console.WriteLine($"Square of {num} is {num * num}");

        var text = "Hello World";
        var sub_text = text.Substring(6,5);
        Console.WriteLine($"Sub Text: {sub_text}");

        var text3 = "Hello World";
        Console.WriteLine($"Uppercase: {text3.ToUpper()}");
        Console.WriteLine($"Lowercase: {text3.ToLower()}");

        var text4 = "   Hello World   ";
        Console.WriteLine($"Trimmed: '{text4.Trim()}'");

        var csv = "apple,banana,cherry";
        var fruits = csv.Split(',');
        Console.WriteLine("Fruits:");
        foreach(var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        var great = "Hello World, Welcome";
        int index = great.IndexOf("el");
        Console.WriteLine($"Index of 'el': {index}");
        Console.WriteLine($"Last Index of 'el': {great.LastIndexOf("el")}");
    }
}