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
        public int Id { get; set; }

        public int CompareTo(Customer other)
        {
            if(Age > other.Age) return 1;
            else if(Age < other.Age) return -1; else return 0;  
        }
    }
    class Users:IComparer<Users>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public int Compare(Users x, Users y)
        {
            if (x.Age > y.Age) return 1;
            else if (x.Age < y.Age) return -1;
            else return 0;
        }
    }
    class CompareStudents:IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if (x.Id > y.Id) return 1;
            else if (x.Id < y.Id) return -1;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer();
            c1.Name = "Vikas"; c1.Address = "Hata"; c1.City = "Hata"; c1.Age = 34; c1.Id = 12;
            Customer c2 = new Customer() { Age = 10, Address = "bheempur", City = "GKP", Name = "Atul", Id = 1};
            Customer c3 = new Customer() { Age = 1, Address = "bheempur", City = "GKP", Name = "Atul", Id = 9};
            Customer c4 = new Customer() { Age = 11, Address = "bheempur", City = "GKP", Name = "Atul", Id = 2};

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);

            //customers.Sort();

            List<Customer> customer = new List<Customer> { c1, c2, c3, c4 };

            CompareStudents obj = new CompareStudents();

            List<Users> users = new List<Users>();

            for (int i = 0; i < customer.Count; i++)
            {
                 users.Add(new Users
                {
                    Id = customer[i].Id,
                    Name = customer[i].Name,
                    Age = customer[i].Age,
                    City = customer[i].City,
                    Address = customer[i].Address
                });
            }

            //customers.Sort(obj);
            customers.Sort(1, 3, obj); 
            /*
            foreach (var item in customers)
            {
                var data = new Users();
                data.Name = item.Name;
                data.Address = item.Address;
                data.City = item.City;
                data.Age = item.Age;
                data.Id = item.Id;

                users.Add(data);
            }
            */
              /*
           foreach (var item in customers)
            {
                 users.Add(new Users
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Age = customer.Age,
                    City = customer.City,
                    Address = customer.Address
                });
            }
            }
            */
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name + " " + item.City + " " + item.Address + " " + item.Age + " " + item.Id);
            }
            Console.WriteLine("\n\n\n");
            foreach (var item in customer)
            {
                Console.WriteLine(item.Name + " " + item.City + " " + item.Address + " " + item.Age + " " + item.Id);
            }
            Console.WriteLine("\n\n\n");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name + " " + item.City + " " + item.Address + " " + item.Age + " " + item.Id);
            }

            Console.ReadLine();
        }
    }
}
