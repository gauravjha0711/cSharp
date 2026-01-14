using System;
using System.Threading;

public class Program
{
    public static void Thread1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread 1: " + i);
        }
    }

    public static void Thread2()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread 2: " + i);
        }
    }

    public static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(Thread1));
        Thread t2 = new Thread(new ThreadStart(Thread2));

        t1.Start();
        Thread.Sleep(3000); // Slight delay to allow interleaving
        t2.Start();
    }
}
