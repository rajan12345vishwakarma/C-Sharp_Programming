using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Generics<T>
    {
        public T Sum(T a, T b)
        {
            dynamic d1 = a; dynamic d2 = b;
            return (d1 + d2);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Generics<int> g = new Generics<int>();
            g.Sum(10, 20);
            Console.WriteLine(g.Sum(1, 2));
            Console.ReadLine();
        }
    }
}
