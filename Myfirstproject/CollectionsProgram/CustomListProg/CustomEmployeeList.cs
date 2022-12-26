using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.CustomListProg
{
    class Department
    {
        public int did;
        public string depname;
        public Department(int did,string depname)
        {
            this.did = did;
            this.depname = depname;
        }
    }
    class Employee
    {
        public int id;
        public string name;
        public Department dp;
        public Employee(int id,string name,Department dp)
        {
            this.id = id;
            this.name = name;
            this.dp = dp;
        }
    }
    class CustomEmployeeList
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee(101, "Aniket", new Department(40, "HR")));
            li.Add(new Employee(106, "nikhil", new Department(30, "Sales")));
            li.Add(new Employee(105, "Rohan", new Department(70, "HR")));
            li.Add(new Employee(103, "mohit", new Department(10, "Sales")));
            li.Add(new Employee(102, "akash", new Department(20, "RND")));
            
            for (int i = 0; i<li.Count; i++)
            {
               for(int k=0;k<li.Count;k++)
                {
                    if(li[i].name.Equals("nikhil")&&li[k].dp.depname.Equals(li[i].dp.depname))
                    {
                        Console.WriteLine(li[k].name+" ");
                    }
                }
            }
        }
    }
}
