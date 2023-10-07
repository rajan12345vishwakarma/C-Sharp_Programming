using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Practice.Rajan;

namespace Practice
{
    class Rajan
    {
       
        public void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b} ");
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b} ");
        }
       
    }
    class Base
    {
        public delegate void AddNum(int a, int b);
        public delegate void SubstractNum(int a, int b);
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Rajan r = new Rajan();
            Base.AddNum x = new Base.AddNum(r.Sum);
            Base.SubstractNum y = new Base.SubstractNum(r.Substract);
            x(1, 2); y(12, 3);
            Console.ReadLine();
        }

    }
}
