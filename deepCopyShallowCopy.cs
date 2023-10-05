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
    class Program
    {
        class A
        {
            public int x;
            public string s;
            public A() { }
            public A(A obj) 
            {
                this.s = obj.s;
                this.x = obj.x;
                Console.WriteLine("Hello world");
            }
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.x = 1;
            a.s = "hello";
            A a2 = a;         // shallow copy
            Console.WriteLine(a2.x + " " + a2.s);
            A a3 = new A(a2);   // deep copy
            Console.WriteLine(a3.x + " " + a3.s);
            Console.ReadLine();
        }
    }
}
