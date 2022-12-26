using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Employee5
    {
        public int eid;
        public string name;
        public Employee5(int eid,string name)
        {
            this.eid = eid;
            this.name = name;
        }
    }
    class Department
    {
        public int did;
        public string dname;
        public List<Employee5> al;

        public Department(int did,string dname,List<Employee5> al)
        {
            this.did = did;
            this.dname = dname;
            this.al = al;
        }
    }
    class CustomListContaiments
    {
        static void Main(string[] args)
        {
            List<Department> li = new List<Department>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the did:");
                int dtid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dname:");
                string dnm = Console.ReadLine();
                List<Employee5> em = new List<Employee5>();
                Console.WriteLine("Enter the details of employee");
                for(int j=1;j<=2;j++)
                {
                    Console.WriteLine("Enter the employee id:");
                    int eid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the employee name:");
                    string name = Console.ReadLine();
                    em.Add(new Employee5(eid, name));
                }
                li.Add(new Department(dtid, dnm, em));
            }
            Console.WriteLine(".................................................");
            foreach(var d in li)
            {
                Console.WriteLine(d.did+" "+d.dname+" ");
                foreach(var e in d.al)
                {
                    Console.Write(" "+e.eid+" "+e.name);
                }
                Console.WriteLine();
            }
        }
    }
}
