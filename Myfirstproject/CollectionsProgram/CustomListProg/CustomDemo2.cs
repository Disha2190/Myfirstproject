using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Employee4 : IComparable
    {
        public int id;
        public string name;
        public int salary;
        public Employee4(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public int CompareTo(Object obj)
        {
            Employee4 e = (Employee4)obj;

            //return this.id - e.id;

            //return this.name.CompareTo(e.name);
            //return e.name.CompareTo(this.name);//descendingstring sorting

            if(this.salary==e.salary)
            {
                return this.id - e.id;
            }
            else
            {
                return e.salary - this.salary;
            }
        }
    }
    class CustomDemo2
    {
        static void Main(string[] args)
        {
            List<Employee4> ep = new List<Employee4>();
            ep.Add(new Employee4(101, "Harry", 25000));
            ep.Add(new Employee4(200, "John", 30000));
            ep.Add(new Employee4(100, "Peter", 56000));
            ep.Add(new Employee4(102, "Jack", 78000));
            foreach (Employee4 e in ep)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.WriteLine("..............................................");
            ep.Sort();
            foreach (Employee4 e in ep)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
        }
    }
}
