using System;
namespace PartialDemo
{
    public class Program
    {
        public static void Main()
        {
            PartialEmployee part = new PartialEmployee();
            part.FirstName = "Gaurav";
            part.LastName = "Jha";
            part.Gender = "Male";
            part.Salary = 45000.00;
            part.DisplayFullName();
            part.DisplayEmployeeDetails();
            part.PartialMethod();
        }
    }
}