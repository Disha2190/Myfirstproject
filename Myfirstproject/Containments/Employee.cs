using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Containments
{
    class Department
    {
        int id;
        string name;
        public Department(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void DisplayDepartment()
        {
            Console.WriteLine(id+" "+name);
        }
    }
    class Employee
    {
        string name;
        int salary;
        int id;
        Department dep;
        public Employee(string name, int salary, int id, Department dep)
        {
            this.name = name;
            this.salary = salary;
            this.id = id;
            this.dep = dep;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine(name+" "+salary+" "+id);
            dep.DisplayDepartment();
        }
        static void Main(string[] args)
        {
            Employee e = new Employee("Disha", 50000, 121, new Department(1,"IT"));
            e.DisplayEmployee();
        }
    }
}
