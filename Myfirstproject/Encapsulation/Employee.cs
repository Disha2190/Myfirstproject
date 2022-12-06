using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class Employee
    {
        private int id;
        private string name;
        private double salary;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        static void Main(string[] args)
        {
            //Property Initializer Syntax
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "Harry";
            e1.Salary = 40000;
            Console.WriteLine($"Id: {e1.Id} Name: {e1.Name} Salary: {e1.Salary}");

            //object Initializew Syntax
            Employee e2 = new Employee { Id = 2, Name = "John", Salary = 50000 };
            Console.WriteLine($"Id: {e2.Id} Name: {e2.Name} Salary: {e2.Salary}");
        }
    }
    class Operator
    {
        static void Main(string[] args)
        {
            int i = 6 / 4 + 4 / 4 + 8 - 2 + 5 / 8;
            int k = 3 / 2 * 4 + 3 / 8 + 3;
            Console.WriteLine(i+" "+k);
        }
    }
}
