using System;
using System.Numerics;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Number for prime number to display: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n==0) Console.WriteLine("No prime numbers available");
        else
        {
            Console.WriteLine($"Prime Numbers upto {n} are: ");
            bool[] prime = new bool[n+1];
            Array.Fill(prime, true);
            prime[0] = prime[1] = false;
            for(int i = 2; i <= n; i++)
            {
                if (prime[i])
                {
                    Console.WriteLine(i);
                    for(int j = i * i; j <= n; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
        }
    }
}