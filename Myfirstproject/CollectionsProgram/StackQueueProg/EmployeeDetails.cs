using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.StackQueueProg
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Stack<Employee> s = new Stack<Employee>();
            s.Push(new Employee(1, "Harry", 45000));
            s.Push(new Employee(2, "Jack", 55000));
            s.Push(new Employee(3, "Peter", 48000));
            s.Push(new Employee(4, "Ron", 49000));
            foreach(var x in s)
            {
                Console.WriteLine(x.id+" "+x.name+" "+x.salary);
            }
            Console.WriteLine("............PEEk.................");
            Console.WriteLine(s.Peek().id+" "+s.Peek().name+" "+s.Peek().salary);
        }
    }
}
