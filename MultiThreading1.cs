using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;  
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    public class MyThread
    {
        public void Thread1()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread t = Thread.CurrentThread;
                    Thread.Sleep(100);
                    Console.WriteLine($"{i} - thread {t.Name} is running");
                }
            }
        }
        public void Thread2()
        {
            for(int i = 0;i < 10; i++)
            {
                Thread t = Thread.CurrentThread;
                Thread.Sleep(100);
                Console.WriteLine($"{i} - thread {t.Name} is running");
            }
        }
    }
    public class ThreadExample
    {
        public static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread2));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "thread1";
            t2.Name = "thread2";
            t3.Name = "thread3";
            t1.Priority = ThreadPriority.BelowNormal;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.AboveNormal;
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
