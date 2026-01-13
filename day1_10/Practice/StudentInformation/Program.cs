using System;
public class Program
{
    public static void Main()
    {
        StudentManager manager = new StudentManager();
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter details for student {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Grade: ");
            string grade = Console.ReadLine();
            Student student = new Student { Id = id, Name = name, Grade = grade };
            manager.AddStudent(student);
        }
        manager.DisplayStudents();
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }
}
public class StudentManager : Student
{
    //use dictionary to store student information
    Dictionary<int, Student> students = new Dictionary<int, Student>();
    public void AddStudent(Student student)
    {
        students[student.Id] = student;
    }
    public void DisplayStudents()
    {
        Console.WriteLine("\nStudent Information:");
        foreach(var student in students.Values)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
        }
    }
}