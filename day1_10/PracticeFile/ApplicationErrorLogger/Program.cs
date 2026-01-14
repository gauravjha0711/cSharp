using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Error Log");
            Console.WriteLine("2. View Error Logs");
            Console.WriteLine("3. Clear Error Logs");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddErrorLog();
                    break;
                case "2":
                    ViewErrorLogs();
                    break;
                case "3":
                    ClearErrorLogs();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    public static void AddErrorLog()
    {
        Console.Write("Enter error Message: ");
        string message = Console.ReadLine();
        FileStream fs = new FileStream("error_log.txt",FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine($"{DateTime.Now.ToShortDateString()}: {message}");
        sw.Close();
        fs.Close();
        Console.WriteLine("Error log added successfully.");
    }
    public static void ViewErrorLogs()
    {
        if (File.Exists("error_log.txt"))
        {
            FileStream fs = new FileStream("error_log.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            Console.WriteLine("Error Logs:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("No error logs found.");
        }
    }
    public static void ClearErrorLogs()
    {
        if (File.Exists("error_log.txt"))
        {
            File.Delete("error_log.txt");
            Console.WriteLine("Error logs cleared successfully.");
        }
        else
        {
            Console.WriteLine("No error logs to clear.");
        }
    }
}