using System;
using System.IO;
public class FileDemo
{
    public void WriteToFile()
    {
        FileStream fileStream = new FileStream(@"D:\cSharp\day1_8\File\Test.txt",FileMode.Open,FileAccess.Write);
        StreamWriter streamWriter = new StreamWriter(fileStream);
        Console.WriteLine("Enter some text: ");
        string str = Console.ReadLine();
        streamWriter.WriteLine(str);
        streamWriter.Close();
        fileStream.Close();
        Console.WriteLine("Text written to file successfully.");
    }

    public void ReadTextData()
    {
        FileStream fileStream = new FileStream(@"D:\cSharp\day1_8\File\Test.txt",FileMode.Open,FileAccess.Read);
        StreamReader streamReader = new StreamReader(fileStream);
        // string str = streamReader.ReadToEnd();
        
        Console.WriteLine("Text read from file: ");

        streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
        string str = streamReader.ReadLine();
        while(str != null)
        {
            Console.WriteLine(str);
            str = streamReader.ReadLine();
        }


        Console.WriteLine(str);
        streamReader.Close();
        fileStream.Close();
    }
}