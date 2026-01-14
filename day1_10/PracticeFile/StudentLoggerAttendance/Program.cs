using System;
using System.ComponentModel;
using System.Data;
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Log Student Attendance. ");
            Console.WriteLine("1. Add Attendance. ");
            Console.WriteLine("2. View Attendance. ");
            Console.Write("Enter your choice (1 or 2): ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AddStudentAttendance();
            }
            else if(choice == "2")
            {
                ViewAttendance();
            }
            else if(choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
    public static void AddStudentAttendance()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Status (Present/Absent): ");
        string status = Console.ReadLine();
        string logEntry = $"{DateTime.Now.ToShortDateString()} | {id} | {name} | {status}";
        FileStream fs = new FileStream("attendance.txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(logEntry);
        sw.Close();
        fs.Close();
    }
    public static void ViewAttendance()
    {
        Console.WriteLine("Attendance Records:");
        if(!File.Exists("attendance.txt"))
        {
            Console.WriteLine("No attendance records found.");
            return;
        }
        else
        {
            FileStream fs = new FileStream("attendance.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            while((line=sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }
    }
}