// using System;
// public class Manager : Employee
// {
//     double Bonus, CA;
//     public override void GetEmployeeData()
//     {   
//         Console.WriteLine("Enter Manager Details:");
//         base.GetEmployeeData();
//         Console.Write("Enter Bonus: ");
//         Bonus = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Enter CA: ");
//         CA = Convert.ToDouble(Console.ReadLine());
//     }
//     public override void DisplayEmployeeData()
//     {
//         Console.WriteLine("\nManager Details:");
//         base.DisplayEmployeeData();
//         Console.WriteLine($"Bonus: {Bonus}");
//         Console.WriteLine($"CA: {CA}");
//     }
//     public override void CalculateSalary()
//     {
//         double totalSalary = Salary + Bonus + CA;
//         Console.WriteLine($"The Total Salary of Manager {Ename} is: {totalSalary}");
//     }
// }