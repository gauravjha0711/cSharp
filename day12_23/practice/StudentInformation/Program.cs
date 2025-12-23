using System;
public class Program
{
    public static void Main()
    {
        Student student1 = new Student();
        Console.WriteLine("Default Student Information:");
        student1.DisplayInfo();

        Console.WriteLine("For Parametrized Constructor: ");
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine();
        Student student2 = new Student(name, age, grade);
        Console.WriteLine("Parametrized Student Information:");
        student2.DisplayInfo();
    }
}