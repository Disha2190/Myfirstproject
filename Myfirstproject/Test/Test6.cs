using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public int allow;
        public int it;
        public int totalSalary, netSalary;

        public Employee()
        {
            id = 0;
            name = "";
            salary = 0;
            allow = 0;

        }
        public Employee(int id, string name, int salary, int allow, int it)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.allow = allow;
            this.it = it;
        }
        public void CalculateSalary()
        {
            totalSalary = salary + allow;
            netSalary = totalSalary - it;
        }
       
        public void Display()
        {
            Console.WriteLine("ID : " + id + "\nName : " + name);
            Console.WriteLine("Total Salary = " + totalSalary);
            Console.WriteLine("Net Salary = " + netSalary);
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee(1, "Harry", 45000, 10000, 2500);
            obj.CalculateSalary();
            obj.Display();
        }
    }
    class Employee1
    {
        public int empid;
        public string empname;
        public int basicsalary;
        public int allowances;
        public double netsalary;
        public Employee1()
        {
            this.empid = 0;
            this.empname = "";
            this.basicsalary = 0;
            this.allowances = 0;
        }
        public Employee1(int empid, string empname,int basicsalary,int allowance)
        {
            this.empid = empid;
            this.empname = empname;
            this.basicsalary = basicsalary;
            this.allowances = allowance;
        }
        public void CalculateSalary(double grossSalary,double IncTax,double ProvFund,double ProfTax)
        {
            netsalary = grossSalary - (IncTax + ProvFund + ProfTax);
        }
        public void Display()
        {
            Console.WriteLine("Id: "+empid);
            Console.WriteLine("Name: "+empname);
            Console.WriteLine("Basic Salary: "+basicsalary);
            Console.WriteLine("Allownace: "+allowances);
            Console.WriteLine("Net Salary: "+netsalary);
        }
        static void Main(string[] args)
        {
            Employee1 obj = new Employee1(1,"Harry",48000,6000);
            obj.CalculateSalary(10000, 1000, 800, 500);
            obj.Display();
        }
    }
    class Student
    {
        int rollno;
        string name;
        int maths, eng, sci, com, phy;
        double per,total;
        public void Accept()
        {
            Console.WriteLine("Enter namne of student:");
            name = Console.ReadLine();
            Console.WriteLine("Enter roll no: ");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maths marks:");
            maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter English marks:");
            eng= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Science marks:");
            sci= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Computer marks:");
            com= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics marks:");
            phy= int.Parse(Console.ReadLine());
        }
        public void Percentage()
        {
            total = maths + eng + sci + com + phy;
            per = (double)(total / 500) * 100;
        }
        public void Display()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Roll No: "+rollno);
            Console.WriteLine("Total Marks are: "+total);
            Console.WriteLine("Percentage are: "+per);
        }
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Accept();
            obj.Percentage();
            obj.Display();
        }
    }
    class Circle
    {
        double r, area;
       public Circle(double r)
        {
            area = 3.14 * r * r;
        }
        public void Display()
        {
            Console.WriteLine("Area of circle is: "+area);
        }
        static void Main(string[] args)
        {
            Circle obj = new Circle(3.5);
            obj.Display();
        }
    }
    class Rectangle
    {
        int l, b,perimeter;
        public Rectangle(int l,int b)
        {
            perimeter = 2*(l+b);
        }
        public void Display()
        {
            Console.WriteLine("Perimeter is: "+perimeter);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length: ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Entr Breadth: ");
            int B = int.Parse(Console.ReadLine());
            Rectangle obj = new Rectangle(L,B);
            obj.Display();
        }
    }
}
