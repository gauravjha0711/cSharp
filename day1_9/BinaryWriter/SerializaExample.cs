using System;
using System.IO;
public class SerializeExample
{
    public static void Main()
    {
        FileStream stream = new FileStream("Student.txt", FileMode.Open);
        BinaryFormatter    formatter = new BinaryFormatter();
    }
}