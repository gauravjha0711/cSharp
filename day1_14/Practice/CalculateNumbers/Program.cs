using System;
public class Program
{
    public static List<int> NumberList = new List<int>();
    public static void Main()
    {
        Console.WriteLine("Enter a number to add in string space separated:");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        foreach(var num in inputs)
        {
            AddNumbers(int.Parse(num));
        }
        double gpa = GetGPAScored();
        if(gpa == 0)
        {
            Console.WriteLine("No numbers available to calculate GPA.");
        }
        else
        {
            Console.WriteLine($"GPA Scored: {gpa}");
            char grade = GetGradeScored(gpa);
            if(grade == '0')
            {
                Console.WriteLine("Invalid GPA.");
            }
            else
            {
                Console.WriteLine($"Grade Scored: {grade}");
            }
        }
    }
    public static void AddNumbers(int Numbers)
    {
        NumberList.Add(Numbers);
    }
    public static double GetGPAScored()
    {
        if(NumberList.Count == 0)
        {
            return -1;
        }
        else
        {
            double totalSum = 0;
            int count = NumberList.Count*3;
            foreach(var number in NumberList)
            {
                totalSum += number*3;
            }
            double ans = totalSum/count;
            return ans;
        }
    }
    public static char GetGradeScored(double gpa)
    {
        if(gpa<5 || gpa>10)
        {
            return '0';
        }
        else if (gpa == 10)
        {
            return 'S';
        }
        else if(gpa>=9 && gpa<10)
        {
            return 'A';
        }
        else if(gpa>=8 && gpa<9)
        {
            return 'B';
        }
        else if(gpa>=7 && gpa<8)
        {
            return 'C';
        }
        else if(gpa>=6 && gpa<7)
        {
            return 'D';
        }
        else if(gpa>=5 && gpa<6)
        {
            return 'E';
        }
        return '0';
    }
}