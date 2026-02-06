using System;
using System.Collections.Generic;
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string Item { get; set; }

    public Stack<Order> AddOrderDetails(int orderId, string customerName, string item)
    {
        Program.OrderStack.Push(new Order
        {
            OrderId = orderId,
            CustomerName = customerName,
            Item = item
        });
        return Program.OrderStack;
    }

    public string GetOrderDetails()
    {
        if (Program.OrderStack.Count == 0)
            return "No Orders Available";

        Order recentOrder = Program.OrderStack.Peek();
        return recentOrder.OrderId + " " + recentOrder.CustomerName + " " + recentOrder.Item;
    }

    public Stack<Order> RemoveOrderDetails()
    {
        if (Program.OrderStack.Count > 0)
            Program.OrderStack.Pop();

        return Program.OrderStack;
    }
}

public class Program
{
    public static Stack<Order> OrderStack { get; set; } = new Stack<Order>();

    public static void Main(string[] args)
    {
        Order order = new Order();

        Console.WriteLine("Enter Order Id:");
        int orderId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Customer Name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter Item:");
        string item = Console.ReadLine();

        order.AddOrderDetails(orderId, customerName, item);

        Console.WriteLine("Most Recent Order:");
        Console.WriteLine(order.GetOrderDetails());

        order.RemoveOrderDetails();

        Console.WriteLine("Remaining Orders Count:");
        Console.WriteLine(OrderStack.Count);
    }
}
