using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.DictionaryProg
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
    class EqualCheck:IEqualityComparer<Employee>
    {
        bool IEqualityComparer<Employee>.Equals(Employee x, Employee y)
        {
            return x.id == y.id && x.name==y.name;
        }
        int IEqualityComparer<Employee>.GetHashCode(Employee obj)
        {
            return obj.id;
        }
    }
    class CustomDictEmployee
    {
        static void Main(string[] args)
        {
            Dictionary<Employee, string> dm = new Dictionary<Employee, string>(new EqualCheck());
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("Enter employee id:");
                int eid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the salary:");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee Department:");
                string dep = Console.ReadLine();
                Employee e = new Employee(eid, name,salary);
                if(dm.ContainsKey(e))
                {
                    Console.WriteLine("Already Present");
                }
                else
                {
                    dm.Add(e, dep);
                }
            }
            foreach(KeyValuePair<Employee, string> kv in dm)
            {
                Employee em = kv.Key;
                Console.WriteLine(em.id+" "+em.name+" "+em.salary+" "+kv.Value);
            }
        }
    }
}
