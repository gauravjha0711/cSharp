using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
[Serializable]
class Student
{
    int rollno ;
    string name ;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}