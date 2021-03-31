using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
            Thread t3 = new Thread(new ThreadStart(MyThread.Thread3));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t3.Join();
            t2.Join();

            Console.ReadKey();
        }
    }

    public class MyThread
    {
        public static void Thread1()
        {
            int ris;
            float res;
            int num = 9;
            ris = 100 / num;
            res = 100 % num;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("T1 Valore num = " + num);
                Console.WriteLine("T1 Valore ris = " + ris);
                Console.WriteLine("T1 Valore res = " + res);
                Thread.Sleep(300);
            }
        }

        public static void Thread2()
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("T2 tabellina 43*" + i + "= " + (43 * i));
                Thread.Sleep(700);
            }
        }

        public static void Thread3()
        {
            for (int i = 0; i< 30; i++)
            {
                Thread.Sleep(300);
                Console.WriteLine("T3 Alessandro");
            }
        }
    }
}
