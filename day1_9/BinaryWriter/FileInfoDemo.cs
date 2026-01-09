using System;
using System.IO;
public class FileInfoDemo
{
    public static void ShowFileInfo()
    {
        //The FileInfo class is used to create, copy, delete, move, and open files, and helps to create FileStream objects.
        // string path  = @"MyTestFile.txt";
        // FileInfo fileInfo = new FileInfo(path);
        // File.Create(path);
        // {
        //     Console.WriteLine("File has been created.");
        // }

        // //The CreateText method is used to create a text file and returns a StreamWriter that can be used to write text to the file.
        // FileInfo fi = new File(@"MyTestFileCreatedText.txt");
        // StreamWriter str = fi.CreateText();
        // str.WriteLine("This is my first line.");
        // Console.WriteLine("Text written to file successfully.");
        // str.Close();

        // //This method is used to delete a file
        // FileInfo fi = new FileInfo(@"MyInfoFile2.txt");
        // fi.Delete();
        // Console.WriteLine("File Deleted successfully");


        // //The CopyTo method is used to copy a existing file to a new file.
        // string path = @"MyTestFile7.txt";
        // string path2 = @"NewFile.txt";
        // FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = fi1.CopyTo(path2);
        // fi1.CopyTo(path2);
        // Console.WriteLine($"{path} File copied {path2} successfully.");


        //moving to file for one folder to another folder
        // string path3 = @"D:\cSharp\day1_9\Data1\File1.txt";
        // string path4 = @"D:\cSharp\day1_9\Data2\File1.txt";
        // FileInfo fi3 = new FileInfo(path3);
        // fi3.MoveTo(path4);
        // Console.WriteLine($"File moved from {path3} to {path4} successfully.");


        //This method create a StreamWriter that append text to file represented by this instance of FileInfo
        FileInfo fi = new FileInfo(@"AppendFile.txt");
        StreamWriter sw = fi.AppendText();
        sw.WriteLine("This is appended line.");
        sw.WriteLine("This is second appended line.");
        Console.WriteLine("Text appended to file successfully.");
        sw.Close();        
    }
}   