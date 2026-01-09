using System;
using System.IO;
public class BinaryWriterDemo
{
    public static void WriteEmployeeData()
    {
        string filePath = "employee.dat";
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101); // Employee ID int
            writer.Write("Gaurav Jha"); // Employee Name string
            writer.Write(55000.50); // Employee Salary double
            writer.Write(true); // Is Active bool
        }
        Console.WriteLine("Employee data written to binary file successfully.");
    }

    public static void ReadEmployeeData()
    {
        string filePath = "employee.dat";
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int id = reader.ReadInt32();
            string name = reader.ReadString();
            double salary = reader.ReadDouble();
            bool isActive = reader.ReadBoolean();
            Console.WriteLine($"ID: {id}, Name: {name}, Salary: {salary}, Permanent: {isActive}");
        }
    }
}