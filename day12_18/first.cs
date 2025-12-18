using System;
class First
{
    static void Main()
    {
        Console.WriteLine("Enter first number : ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number : ");
        int num2 = Int32.Parse(Console.ReadLine());
        int sum = num1 + num2;
        int discount = (sum)*10/100;
        int finalAmount = sum - discount;
        Console.WriteLine("Price of first Product is : {0}",num1);
        Console.WriteLine("Price of second Product is : {0}", num2);
        Console.WriteLine("The final amount after 10% discount is : {0}", finalAmount);

    }
}