using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Constant
    {
        const int no = 80;
        public void Show()
        {
            Console.WriteLine("No is: "+no);
        }
        static void Main(string[] args)
        {
            Constant obj = new Constant();
            obj.Show();
            const double PI = 3.14;
            double r = 2.3, area;
            area = PI * r * r;
            Console.WriteLine("Area is: "+area );
        }
    }
    class Student2  //ReadOnly
    { 
        readonly int rollno;
        public string name;
        public Student2(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Rollno: "+rollno);
            Console.WriteLine("Name: "+name);
        }
        static void Main(string[] args)
        {
            Student2 stud1 = new Student2(1, "Rahul");
            Student2 stud2 = new Student2(2, "Nisha");
            Student2 stud3 = new Student2(3, "Deepa");
            stud1.Display();
            stud2.Display();
            stud3.Display();
     
        }
    }
  
}
