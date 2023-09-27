using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello sir how are you";
            Console.WriteLine(s.WordCount());
            Console.WriteLine(MyExtensions.WordCount("hello.world is this"));
            Console.ReadLine();
        }
    }
}
