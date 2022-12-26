using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Employee3:IComparable<Employee3>
    {
        public int id;
        public string name;
        public int salary;
        public Employee3(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        int IComparable<Employee3>.CompareTo(Employee3 other)
        {
            /*  if(this.id>other.id)
              {
                  return 1;
              }
              else if(this.id<other.id)
              {
                  return -1;
              }
              else
              {
                  return 0;
              }*/


            //return this.id - other.id;
            return other.id - this.id;  //descending sort on Id
        }
    }
    class CustomListDemo1
    {
        static void Main(string[] args)
        {
            List<Employee3> ep = new List<Employee3>();
            ep.Add(new Employee3(101, "Harry", 25000));
            ep.Add(new Employee3(200, "John", 30000));
            ep.Add(new Employee3(100, "Peter", 56000));
            ep.Add(new Employee3(102, "Jack", 78000));
            foreach (Employee3 e in ep)
            {
                    Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.WriteLine("..............................................");
            ep.Sort();
            foreach (Employee3 e in ep)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
        }
    }
}
