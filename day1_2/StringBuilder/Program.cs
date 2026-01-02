using System;
using System.Globalization;
using System.Text;
public class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello World!");
        for(int i=0;i<sb.Length;i++)
        {
            Console.Write(sb[i]);
        }
        Console.WriteLine();

        StringBuilder sb2 = new StringBuilder();
        sb2.Append("Hello");
        sb2.Append(", ");
        sb2.AppendLine(" World!");
        sb2.AppendLine("Welcome to C# programming.");
        sb2.Append("Have a great day!");
        Console.WriteLine(sb2);


        StringBuilder sbAmount = new StringBuilder("Your total amount is: ");
        sbAmount.AppendFormat("{0:c},",25);

        CultureInfo india = new CultureInfo("en-IN");
        sbAmount.AppendFormat(india, " (in Indian culture: {0:c})", -12345678);
        Console.WriteLine(sbAmount);

        StringBuilder sb3 = new StringBuilder("Hello World!");
        sb3.Insert(5," c#");
        Console.WriteLine(sb3);

        StringBuilder sb4 = new StringBuilder("Hello c# World!",50);
        sb4.Remove(5,3);
        Console.WriteLine(sb4);
    }
}