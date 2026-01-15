using System;
public class Student
{
    public event Action<int> GradeChanged;
    public void UpdateGrade(int grade)
    {
        GradeChanged?.Invoke(grade);
    }
}

public class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.GradeChanged += (grade) =>
        {
            Console.WriteLine($"Grade changed to: {grade}");
        };
        Console.Write("Enter new grade for the student: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int grade))
        {
            student.UpdateGrade(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade.");
        }
    }
}
