using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Inheritance
{
    //Single Inheritance
    class Person
    {
        public string name = "Harry";
        public void Show()
        {
            Console.WriteLine("I am Person and Student");
        }
    }
    class Student:Person
    {
        public string course = "Engineering";
        public void Show1()
        {
            Console.WriteLine("Name: "+name+" Course: "+course);
         
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Show();
            s.Show1();
        }
    }

    // Multilevel Inheritance

    class Person1
    {
        public string name = "Harry";
        public void Show()
        {
            Console.WriteLine("I am Person and Student");
        }
    }
    class Student1 : Person1
    {
        public string course = "Engineering";
        public void Show1()
        {
            Console.WriteLine("Name: " + name + " Course: " + course);

        }
    }
    class Engineering:Student1
    {
        public string Branch = "IT";
        public void Show2()
        {
            Console.WriteLine("Branch: "+Branch);
        }
    }
    class PersonDetails
    {
        static void Main(string[] args)
        {
            Engineering e = new Engineering();
            e.Show();
            e.Show1();
            e.Show2();
        }
    }

    //Hierarchical Inheritance
    class Person2
    {
        public void Show()
        {
            Console.WriteLine("I am Person");
        }
    }
    class Student2 : Person2
    {
        public string course = "Engineering";
        public void Show1()
        {
            Console.WriteLine("I am Student");
            Console.WriteLine("Course: " + course);
        }
    }
    class Teacher :Person
    {
        public string profession = "Teacher";
        public void Show3()
        {
            Console.WriteLine("Profession: "+profession);
        }
    }
    class PersonDetails2
    {
        static void Main(string[] args)
        {
            Student2 s = new Student2();
            s.Show();
            s.Show1();
            Teacher t = new Teacher();
            t.Show();
            t.Show3();
        }
    }
}
