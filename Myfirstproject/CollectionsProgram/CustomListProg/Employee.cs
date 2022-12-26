using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;
        public Employee(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

    }
    class EmployeeCustomList
    {
        static void Main(string[] args)
        {
            List<Employee> ep = new List<Employee>();
            ep.Add(new Employee(1, "Harry", 25000));
            ep.Add(new Employee(2, "John", 30000));
            ep.Add(new Employee(3, "Peter", 35000));
            
            foreach(Employee e in ep)
            {
                if(e.salary>25000)
                {
                    Console.WriteLine(e.id+" "+e.name+" "+e.salary);
                }
            }
        }
    }
}
