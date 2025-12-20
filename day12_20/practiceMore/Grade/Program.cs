using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enetr Score: ");
        int score = Convert.ToInt32(Console.ReadLine());
        char grade;
        if(score >= 90)
        {
            grade = 'A';
        }
        else if(score >= 80)
        {
            grade = 'B';
        }
        else if(score >= 70)
        {
            grade = 'C';
        }
        else if(score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        Console.WriteLine($"Grade: {grade}");
    }
}