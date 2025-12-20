using System;
class Student
{
    // 12) program to read student num,name,mark of six subject in property and 
    // calculate total and average and print result and division */
    // program that reads a student’s exam score from the user and determines their grade based on the following grading scale:
    // Score ≥ 90 : Grade A
    // 80 ≥ Score < 90 : Grade B
    // 70 ≥ Score < 80 : Grade C
    // 60 ≥ Score < 70 : Grade D
    // Score < 60 : Grade F

    private int _stuNum;
    private string _stuName = string.Empty;
    private float[] _marks = new float[6];
    private float _total = 0.0f;
    private float _average = 0.0f;
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Student Numvber: ");
        StuNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student Name: ");
        StuName = Console.ReadLine() ?? string.Empty;
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Enter marks for subject {i + 1}: ");
            _marks[i] = Convert.ToSingle(Console.ReadLine());
        }
    }
    public void CalculateResults()
    {
        _total = 0.0f;
        for (int i = 0; i < 6; i++)
        {
            _total += _marks[i];
        }
        _average = _total / 6.0f;
    }
    public void DisplayResults()
    {
        Console.WriteLine($"Student Number: {StuNum}");
        Console.WriteLine($"Student Name: {StuName}");
        Console.WriteLine($"Total Marks: {_total}");
        Console.WriteLine($"Average Marks: {_average}");
        Console.WriteLine($"Division: {GetDivision()}");
    }
    private string GetDivision()
    {
        if (_average >= 90)
            return "A";
        else if (_average >= 80)
            return "B";
        else if (_average >= 70)
            return "C";
        else if (_average >= 60)
            return "D";
        else
            return "F";
    }
    public int StuNum
    {
        get { return _stuNum; }
        set { _stuNum = value; }
    }
    public string StuName
    {
        get { return _stuName; }
        set { _stuName = value; }
    }
    public float[] Marks
    {
        get {return _marks; }
        set {_marks = value; }
    }
}