using System;
namespace PartialDemo
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Salary: {Salary}");
        }
        public partial void PartialMethod()
        {
            Console.WriteLine("Partial Method Invoked");
        }
    }
}