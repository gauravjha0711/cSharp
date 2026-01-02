using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        Employee emp1 = new Employee(101,"gaurav");
        Employee emp2 = new Employee(102,"kundan");
        Employee emp3 = new Employee(103,"krishna");
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        list.Add(60.45f);
        list.Add(false);
        list.Add(emp1);
        list.Add(emp2);
        list.Add(emp3);
        Console.WriteLine($"Count of ArrayList is : {list.Count}");
        // for(int i=0;i<list.Count;i++)
        // {
        //     Console.WriteLine(list[i]);
        // } 
        // foreach(var item in list)
        // {
        //     Console.WriteLine(item);
        // }


        ArrayList list1 = new ArrayList();
        list1.Add(60);
        list1.Add(70);
        list1.Add(80);
        list.AddRange(list1);
        Console.WriteLine($"Count of ArrayList is : {list.Count}");
        Console.WriteLine("After adding the range of elements:");
        // foreach(var item in list)
        // {
        //     Console.WriteLine(item);
        // }
        // list.Clear();
        // Console.WriteLine($"Count of ArrayList after clearing is : {list.Count}");

        if(list.Contains(30))
        {
            Console.WriteLine("30 is present in the ArrayList");
        }
        else
        {
            Console.WriteLine("30 is not present in the ArrayList");
        }
        list.RemoveAt(3);
        Console.WriteLine("After removing the element at index 3:");
        // foreach(var item in list)
        // {
        //     Console.WriteLine(item);
        // }
        list.RemoveRange(2,3);
        Console.WriteLine("After removing the range of elements from index 2 to 4:");
        // foreach(var item in list)
        // {
        //     Console.WriteLine(item);
        // }
        list.Insert(2,500);
        Console.WriteLine("After inserting 500 at index 2:");
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    }
}