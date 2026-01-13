using System.Collections.Generic;
using System.Data;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    public static void Main()
    {
        // Console.WriteLine("Heello, LINQ!");
        //DataSource;
        // string[] names = {"gaurav","kundan","krishna","shubham","john"};

        // //write the query
        // //IEnumerable<string> names
        //query syntax
        // // var name = from s in names where s.Contains('a') select s;
        // //method syntax
        // var name = names.Where(s=>s.Contains('a'));
        // var name2 = name.Where(s=>s.Length>6);
        // //execute the query
        // foreach(string s in name)
        // {
        //     Console.WriteLine(s);
        // }
        // Console.WriteLine("--------");
        // foreach(string s in name2)
        // {
        //     Console.WriteLine(s);
        // }



        // IList<string> stringList = new List<string>()
        // {
        //     "c# tutorial",
        //     "java tutorial",
        //     "python tutorial",
        //     "learn c++",
        //     "java",
        // };
        // var result = stringList.Where(s=>s.Contains("tutorial"));
        // foreach(var str in result)
        // {
        //     Console.WriteLine(str);
        // }



        //student Collection
        // IList<Student> studentList = new List<Student>()
        // {
        //     new Student(){Id=1, Name="gaurav",Age=24},
        //     new Student(){Id=2, Name="kundan",Age=26},
        //     new Student(){Id=3, Name="krishna",Age=22},
        //     new Student(){Id=4, Name="shubham",Age=28},
        //     new Student(){Id=5, Name="john",Age=30},
        // };
        // var adult = studentList.Where(s=>s.Age>25 && s.Age<30);
        // foreach(var student in adult)   
        // {
        //     Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        // }




        //Data Source
        Employees employees = new Employees();
        employees.Rows.Add(1, "Gaurav", 24, "IT", 50000);
        employees.Rows.Add(2, "Kundan", 26, "HR", 60000);
        employees.Rows.Add(3, "Krishna", 22, "IT", 55000);
        employees.Rows.Add(4, "Shubham", 28, "Finance", 70000);

        //write Linq Query
        var empQuery = from emp in employees.AsEnumerable() 
                          where emp.Field<string>("Department")=="IT" 
                          orderby emp.Field<double>("Salary") descending
                          select new
                          {
                                Id = emp.Field<int>("Id"),
                                Name = emp.Field<string>("Name"),
                                Age = emp.Field<int>("Age"),
                                Department = emp.Field<string>("Department"),
                                Salary = emp.Field<double>("Salary")
                          };
        //Execute the Query
        foreach(var emp in empQuery)
        {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
    }
}