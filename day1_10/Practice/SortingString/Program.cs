using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter strings space separated:");
        string input = Console.ReadLine();
        string[] strings = input.Split(' ');
        List<string> StringList = new List<string>(strings);
        StringList.Sort((a,b)=>{
            int lenCompare = a.Length.CompareTo(b.Length);
            if(lenCompare == 0)
                return 0;
            return -lenCompare;
        });
        Console.WriteLine("Sorted Strings: " + string.Join(" ", StringList));
    }
}