using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class CompObj
    {
        double per;
        int chem, phy, math, comp, sci,id;
        string name;
        public void Accept()
        {
            Console.WriteLine("Enter Student name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Id:");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths marks:");
            math = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Physics marks:");
            phy = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry marks:");
            chem = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Computer marks:");
            comp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Science marks:");
            sci = int.Parse(Console.ReadLine());

        }
        public double Percentage()
        {
            double total = math + chem + phy + comp + sci;
            per = (double)(total / 500) * 100;
            return per;
        }
        public void Display()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("id: "+id);
            Console.WriteLine("Percentage are:"+Percentage());
        }
        static void Main(string[] args)
        {
            CompObj obj1 = new CompObj();
            CompObj obj2 = new CompObj();
            obj1.Accept();
            obj2.Accept();
            if(obj1.Percentage()>obj2.Percentage())
            {
                obj1.Display();
            }
            else
            {
                obj2.Display();
            }
        }
    }

    class Student
    {
        public int id;
        public string name;
        public int age;
        public double sub1;
        public double sub2;
        public double sub3;
        public double per;

        public void Accept()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject 1 Marks");
            sub1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Subject 2 Marks");
            sub2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Subject 3 Marks");
            sub3 = Convert.ToDouble(Console.ReadLine());
        }
        /*public void GetInfo()
        {
            id = 5;
            name = "Rahul";
            age = 20;
        }*/

        public void Display()
        {
            Console.WriteLine("Id := " + id);
            Console.WriteLine("Name := " + name);
            Console.WriteLine("Age := " + age);
            Console.WriteLine("Percentage := " + per);
        }
       /* public void GetInfo(int id, string name, int age, int s1, int s2, int s3)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sub1 = s1;
            this.sub2 = s2;
            this.sub3 = s3;
        }*/
        public double CalPer()
        {
            double total = sub1 + sub2 + sub3;
            per = (total / 300) * 100;

            return per;
        }
        public char Grade()
        {
            if (per >= 75)
            {
                return 'A';
            }
            else if (per < 75 && per >= 60)
            {
                return 'B';
            }
            else if (per < 60 && per >= 35)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }
        static void Main(string[] args)
        {
            /*Student s = new Student();
            s.GetInfo();
            s.PutInfo();*/
            Student s1 = new Student();
            s1.Accept();
            Student s2 = new Student();
            s2.Accept();

            if (s1.CalPer() > s2.CalPer())
            {
                s1.Display();
            }
            else
            {
                s2.Display();
            }

            /* Console.WriteLine("Percentage is := "+s1.CalPer());
             Console.WriteLine("Grade is := "+s1.Grade());*/
        }




    }
}
