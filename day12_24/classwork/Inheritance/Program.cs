using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main()
    {
        // object initialization syntax
        Employee employee = new Employee
        {
            EmployeeID = 101,
            Name = "John Doe",
            Salary = 50000.0f
        };
        // Console.WriteLine("Employee Details:");
        // Console.WriteLine($"Employee ID: {employee.EmployeeID}");
        // Console.WriteLine($"Employee Name: {employee.Name}");
        // Console.WriteLine($"Employee Salary: {employee.Salary}");

        // System.Console.WriteLine($"Employee Object: {employee}");

        // Program program = new Program();
        // // program.Add(10, 20);
        // int[] arr = { 1, 2, 3, 4, 5 };
        // program.Add(arr);


        // Calculator calculator = new Calculator();
        // Console.WriteLine("Add with no parameters: " + calculator.Add());
        // Console.WriteLine("Add with two integers: " + calculator.Add(15, 25));
        // Console.WriteLine("Add with two strings: " + calculator.Add("Hello, ", "World!"));
        // Console.WriteLine("Add with two floats: " + calculator.Add(10.5f, 20.3f));


        // double distance = 150.0;
        // double hours = 3.0;
        // double fuel = 10.0;
        // Vehical vehical = new Vehical(distance, hours, fuel);
        // vehical.Average();  //calling base class method
        // vehical.Speed();    //calling base class method

        // Car car = new Car(distance, hours, fuel);
        // car.Average();     //calling derived class method (method hiding)
        // car.Speed();       //calling derived class method (method overriding)


        // Furniture furniture = new Furniture(); //cannot create instance of abstract class but can create reference
        Bookshelve bookshelve = new Bookshelve();
        bookshelve.Accept();
        bookshelve.Display();

        Furniture furniture = new Chair();
        furniture.Mymethod(); //calling base class method

        Chair chair = new Chair();
        chair.Accept();
        chair.Display();

    }
    public void Add(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine($"Sum: {sum}");
    }
    public void Add(params int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of Array: {sum}");
    }
}