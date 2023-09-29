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
    class Customer:IComparable<Customer>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public int CompareTo(Customer other)
        {
            if(this.Age >  other.Age) return 1;
            else if(this.Age < other.Age) { return -1; } else {  return 0; }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer();
            c1.Name = "Vikas"; c1.Address = "Hata"; c1.City = "Hata"; c1.Age = 34;
            Customer c2 = new Customer() { Age = 10, Address = "bheempur", City = "GKP", Name = "Atul"};
            Customer c3 = new Customer() { Age = 1, Address = "bheempur", City = "GKP", Name = "Atul"};
            Customer c4 = new Customer() { Age = 11, Address = "bheempur", City = "GKP", Name = "Atul"};

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);

            customers.Sort();

            foreach (var item in customers)
            {
                Console.WriteLine(item.Name + " " + item.City + " " + item.Address + " " + item.Age);
            }
            List<Customer> cust = new List<Customer> { c1, c2, c3,c4 };
            Console.WriteLine("\n\n\n");

            foreach (var item in cust)
            {
                Console.WriteLine(item.Name + " " + item.City + " " + item.Address + " " + item.Age);
            }
            

            Console.ReadLine();
        }
    }
}
