using System;
using System.Threading;

// public class Program
// {
//     public static void Thread1()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine("Thread 1: " + i);
//             Thread.Sleep(1000); // Simulate some work
//         }
//     }

//     public static void Thread2()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine("Thread 2: " + i);
//             Thread.Sleep(1000); // Simulate some work
//         }
//     }
//     public static void Thread3()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine("Thread 3: " + i);
//             Thread.Sleep(1000); // Simulate some work
//         }
//     }

//     public static void Main()
//     {
//         // Thread t1 = new Thread(new ThreadStart(Thread1));
//         // Thread t2 = new Thread(new ThreadStart(Thread2));

//         // t1.Start();
//         // Thread.Sleep(3000); // Slight delay to allow interleaving
//         // t2.Start();
//         // try
//         // {
//         //     t1.Abort();
//         //     t2.Abort();
//         // }
//         // catch (ThreadAbortException e)
//         // {
//         //     Console.WriteLine("Thread aborted: " + e.Message);
//         // }

//         Thread t1 = new Thread(new ThreadStart(Thread1));
//         Thread t2 = new Thread(new ThreadStart(Thread2));
//         Thread t3 = new Thread(new ThreadStart(Thread3));
//         t1.Start();
//         t1.Join(); // Wait for t1 to finish
//         t2.Start();
//         t2.Join(); // Wait for t2 to finish
//         t3.Start();
//         t3.Join(); // Wait for t3 to finish

//     }
// }



// public class ThreadClass
// {
//     public static void Thread1()
//     {
//         Thread t = Thread.CurrentThread;
//         Console.WriteLine($"Thread Name: {t.Name} Running with Priority: {t.Priority}");
//     }
// }
// public class Program
// {
//     public static void Main()
//     {
//         Thread t1 = new Thread(new ThreadStart(ThreadClass.Thread1));
//         Thread t2 = new Thread(new ThreadStart(ThreadClass.Thread1));
//         Thread t3 = new Thread(new ThreadStart(ThreadClass.Thread1));
//         t1.Name = "T1";
//         t2.Name = "T2";
//         t3.Name = "T3";
//         t3.Priority = ThreadPriority.Highest;
//         t2.Priority = ThreadPriority.Normal;
//         t1.Priority = ThreadPriority.Lowest;
//         t1.Start();
//         t2.Start();
//         t3.Start();
//     }
// }





public class ThreadClass
{
    public void Thread1()
    {
        lock(this)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.Name}: " + i);
                Thread.Sleep(500); // Simulate some work
            }
        }
    }
}
public class Program
{
    public static void Main()
    {
        ThreadClass p = new ThreadClass();
        Thread t1 = new Thread(new ThreadStart(p.Thread1));
        Thread t2 = new Thread(new ThreadStart(p.Thread1));
        Thread t3 = new Thread(new ThreadStart(p.Thread1));
        t1.Name = "T1";
        t2.Name = "T2";
        t3.Name = "T3";
        t3.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Normal;
        t1.Priority = ThreadPriority.Lowest;
        t1.Start();
        t2.Start();
        t3.Start();
    }
}