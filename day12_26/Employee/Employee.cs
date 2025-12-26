// using System;
// public class Employee
// {
//     protected int Eid, Eage;
//     protected string Ename,Eaddress;
//     protected float Salary;
//     public virtual void GetEmployeeData()
//     {
//         Console.WriteLine("Enter Employee Details: ");
//         Console.Write("Employee ID: ");
//         Eid = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Employee Name: ");
//         Ename = Console.ReadLine();
//         Console.WriteLine("Employee Address: ");
//         Eaddress = Console.ReadLine();
//         Console.WriteLine("Employee Age: ");
//         Eage = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Employee Salary: ");
//         Salary = float.Parse(Console.ReadLine());
//     }
//     public virtual void DisplayEmployeeData()
//     {
//         Console.WriteLine("\nEmployee Details:");
//         Console.WriteLine($"Employee ID: {Eid}");
//         Console.WriteLine($"Employee Name: {Ename}");
//         Console.WriteLine($"Employee Address: {Eaddress}");
//         Console.WriteLine($"Employee Age: {Eage}");
//         Console.WriteLine($"Employee Salary: {Salary}");
//     }
//     public virtual void CalculateSalary()
//     {
//         Console.WriteLine($"The Salary of Employee {Ename} is: {Salary}");
//     }
// }