using System;
public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public float Salary { get; set; }
    public Employee()
    {
        EmployeeID = 0;
        Name = string.Empty;
        Salary = 0.0f;
    }
    public Employee(int employeeID, string name, float salary)
    {
        this.EmployeeID = employeeID;
        this.Name = name;
        this.Salary = salary;
    }

    // Override ToString method
    public override string ToString()
    {
        return $"Employee Details are: \nEmployeeID: {EmployeeID}\nName: {Name}\nSalary: {Salary}";
    }
}