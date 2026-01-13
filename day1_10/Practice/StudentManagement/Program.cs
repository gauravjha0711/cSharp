using System;
public class Program
{
    public static void Main()
    {
        LinkedList<string> studentList = new LinkedList<string>();
        while (true)
        {
            Console.WriteLine("LinkedList operations: ");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student by Name");
            Console.WriteLine("5. Clear List");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: 1 to 6: ");

            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Student name to add: ");
                    string nameToAdd = Console.ReadLine();
                    studentList.AddLast(nameToAdd);
                    break;
                case 2:
                    Console.WriteLine("Student List: ");
                    if(studentList.Count == 0)
                    {
                        Console.WriteLine("No students in the list.");
                        break;
                    }
                    foreach(var student in studentList)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 3:
                    Console.Write("Enter existing student name to update: ");
                    string existingName = Console.ReadLine();
                    if (studentList.Contains(existingName))
                    {
                        Console.Write("Enter new Student name: ");
                        string newName = Console.ReadLine();
                        var node = studentList.Find(existingName);
                        studentList.AddAfter(node, newName);
                        studentList.Remove(existingName);
                        Console.WriteLine("Student updated.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case 4:
                    Console.Write("Enter student name to delete: ");
                    string nameToDelete = Console.ReadLine();
                    if (studentList.Remove(nameToDelete))
                    {
                        Console.WriteLine("Student removed.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case 5:
                    studentList.Clear();
                    Console.WriteLine("Student list cleared.");
                    break;
                case 6:
                    return;
            }
        }

    }
}