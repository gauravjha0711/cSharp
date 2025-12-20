using System;
class Employee
{
    // public int EmpId=0;
    // public string Name=string.Empty;
    // public string Department=string.Empty;
    // public float Salary=0.0f;
    // public bool Status = true;

    private int _empId;
    private string _name = string.Empty;
    private string _department = string.Empty;
    private float _salary = 0.0f;
    private bool _status = true;
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Id:");
        EmpId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name:");
        Name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Enter Employee Department:");
        Department = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Enter Employee Salary:");
        Salary = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Employee Status (true/false):");
        Status = Convert.ToBoolean(Console.ReadLine());
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee Id: {EmpId}");
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee Department: {Department}");
        Console.WriteLine($"Employee Salary: {Salary}");
        Console.WriteLine($"Employee Status: {Status}");
    }
    public int EmpId
    {
        get { return _empId; }
        set { _empId = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }
    public float Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }
    public bool Status
    {
        get { return _status; }
        set { _status = value; }
    }
}