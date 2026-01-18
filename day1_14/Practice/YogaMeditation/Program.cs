using System;
using System.Collections;
using System.Runtime.Intrinsics.X86;
public class MeditationCenter
{
    public int MemberID { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string Goal { get; set; }
    public double BMI { get; set; }
}
public class Program
{
    public static ArrayList MemberList = new ArrayList();
    public static void Main()
    {
        Console.WriteLine("Enter Yoga Member Details:");
        Console.Write("MemberID: ");
        int memberId = int.Parse(Console.ReadLine());
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Weight (in kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Height (in inch): ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Goal (Weight Loss/Weight Gain): ");
        string goal = Console.ReadLine();
        AddYogaMember(memberId, age, weight, height, goal);
        int fee = CalculateYogaFee(memberId);
        if(fee == 0)
        {
            Console.WriteLine("Unable to calculate fee. Please check member details.");
        }
        else
        {
            Console.WriteLine($"The Yoga Fee for Member ID {memberId} is: {fee}");
        }
    }
    public static void AddYogaMember(int memberId, int age,double weight,double height,string goal)
    {
        MeditationCenter member = new MeditationCenter()
        {
            MemberID = memberId,
            Age = age,
            Weight = weight,
            Height = height,
            Goal = goal,
            BMI = CalculateBMI(weight, height)
        };
        MemberList.Add(member);
    }
    public static double CalculateBMI(double weight, double height)
    {
        double heightInMeters = height * 0.0254;
        double bmi = weight / (heightInMeters * heightInMeters);
        return bmi;
    }
    public static int CalculateYogaFee(int memberId)
    {
        if (MemberList.Count == 0)
        {
            return 0;
        }
        else if (memberId <= 0)
        {
            return 0;
        }
        else
        {
            foreach (MeditationCenter member in MemberList)
            {
                if (member.MemberID == memberId)
                {
                    if(member.Goal=="Weight Loss")
                        {
                            if(member.BMI>=25 && member.BMI<30)
                        {
                            return 2000;
                        }
                        else if(member.BMI>=30 && member.BMI<35)
                        {
                            return 2500;
                        }
                        else if(member.BMI>=35)
                        {
                            return 3000;
                        }
                    }
                    else if(member.Goal == "Weight Gain")
                    {
                        return 2500;
                    }
                }
            }
            return 0;
        }
    }
}