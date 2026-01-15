using System;
public class Student
{
    public string Name { get; set; }
    public int RollNo { get; set; }
    public Student()
    {
        Name = string.Empty;
        RollNo = 0;
    }
    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNo}");
    }
}