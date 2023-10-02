using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message { get { return "Attempt to divide by odd number"; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ener second number");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 > 0)
            {
                //throw new ApplicationException("divisor value can't be odd number");
                throw new DivideByOddNoException();
            }
            int res = x % y;
            Console.WriteLine($"result = {x/y}");
            Console.ReadLine();
        }
    }
}
