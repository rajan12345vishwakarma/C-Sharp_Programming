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
            try
            {
                test1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            Console.ReadLine();
        }
        public static void test1()
        {
            try
            {
                test2();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void test2()
        {
            try
            {
                test3();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void test3()
        {
            try
            {
                test4();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void test4()
        {
            try
            {
                test5();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void test5()
        {
            try
            {
                test6();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void test6()
        {
            try
            {
                int x = 10;
                int y = 0;
                int res = x / y;
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

/*
 if we throw ex then it stops stack trace and if we don't throw ex then 
 it print all the stack trace if any error comes.
 */
