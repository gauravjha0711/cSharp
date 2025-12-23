using System;
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Student()
    {
        Name = "Gaurav Jha";
        Age = 21;
        Grade = "A";
    }    
    public Student(string Name, int Age, string Grade)
    {
        this.Name = Name;
        this.Age = Age;
        this.Grade = Grade;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}