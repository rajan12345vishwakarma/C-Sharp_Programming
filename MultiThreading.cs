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
            for (int i = 0; i < 10; i++)
            {
                Thread t = Thread.CurrentThread;
                Thread.Sleep(1000);
                Console.WriteLine($"{i} - thread {t.Name} is running");
            }
        }
        public void Thread2()
        {
            for(int i = 0;i < 10; i++)
            {
                Thread t = Thread.CurrentThread;
                Thread.Sleep(1000);
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
            t1.Name = "thread1";
            t2.Name = "thread2";
            t1.Start();
            t1.Join();
            t2.Start();
            Console.ReadLine();
        }
    }
}

/*
     output : 
              0 - thread thread1 is running
              1 - thread thread1 is running
              2 - thread thread1 is running
              3 - thread thread1 is running
              4 - thread thread1 is running
              5 - thread thread1 is running
              6 - thread thread1 is running
              7 - thread thread1 is running
              8 - thread thread1 is running
              9 - thread thread1 is running
              0 - thread thread2 is running
              1 - thread thread2 is running
              2 - thread thread2 is running
              3 - thread thread2 is running
              4 - thread thread2 is running
              5 - thread thread2 is running
              6 - thread thread2 is running
              7 - thread thread2 is running
              8 - thread thread2 is running
              9 - thread thread2 is running
*/
