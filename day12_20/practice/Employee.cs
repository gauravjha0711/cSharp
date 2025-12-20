using System;
class Employee
{
    /*13)program to read eno,ename,basic salary and calculate  
    pf,hra,da,net salary and gross salary and print eno,ename,basic 
    salary,
    gross salary and net salary*/
    // pf= 12% of basic salary.
    // hra=20% of basic salary.
    // da= 15% of basic salary.
    // gross salary=pf+hra+da+basic salary;
    // net salary=gross salary - pf;
    
    private int _emmNo;
    private string _empName = string.Empty;
    private float _basicSalary = 0.0f;
    private float _pf = 0.0f;
    private float _hra = 0.0f;
    private float _da = 0.0f;
    private float _grossSalary = 0.0f;
    private float _netSalary = 0.0f;
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee No:");
        EmmNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name:");
        EmpName = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Enter Basic Salary:");
        BasicSalary = Convert.ToSingle(Console.ReadLine());
    }
    public void CalculateSalaries()
    {
        _pf = 0.12f * _basicSalary;
        _hra = 0.20f * _basicSalary;
        _da = 0.15f * _basicSalary;
        _grossSalary = _basicSalary + _pf + _hra + _da;
        _netSalary = _grossSalary - _pf;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee No: {EmmNo}");
        Console.WriteLine($"Employee Name: {EmpName}");
        Console.WriteLine($"Basic Salary: {BasicSalary}");
        Console.WriteLine($"Gross Salary: {_grossSalary}");
        Console.WriteLine($"Net Salary: {_netSalary}");
    }
    public int EmmNo
    {
        get { return _emmNo; }
        set { _emmNo = value; }
    }
    public string EmpName
    {
        get { return _empName; }
        set { _empName = value; }
    }
    public float BasicSalary
    {
        get { return _basicSalary; }
        set { _basicSalary = value; }
    }
}