using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Employee1:IComparable
    {
        public int id;
        public string name;
        public int salary;
        public Employee1(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public int CompareTo(Object obj)
        {
            Employee1 e = (Employee1)obj;
            return e.salary - this.salary;
        }
    }
    class Employee1Details
    {
        static void Main(string[] args)
        {
            List<Employee1> li = new List<Employee1>();
            li.Add(new Employee1(101, "yash", 67000));
            li.Add(new Employee1(102, "neha", 70000));
            li.Add(new Employee1(103, "nikhil", 56000));
            li.Add(new Employee1(104, "sonal", 78000));
            foreach (Employee1 e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.WriteLine("...................................");
            li.Sort();
            foreach (Employee1 e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
        }
    }
}
