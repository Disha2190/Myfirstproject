using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Student
    {
        int id, age;
        string name;
        public Student()
        {
            this.id = 0;
            this.name = "";
            this.age = 0;
        }
        public Student(int id, string name, int age):this()   //this
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Student(Student s)
        {
            this.id = s.id;
            this.name = s.name;
            this.age = s.age;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {id} Name: {name} Age:{age}");
        }
        static void Main(string[] args)
        {
            Student obj1 = new Student(1, "AAA", 89); //Paramaterised Constructor
            obj1.Display();
            Student obj2 = obj1; //Copy Constructor
            obj2.Display();
        }
    }
    class Student1
    {
        int id, age;
        string name;
        public Student1()
        {
            this.id = 0;
            this.name = "";
            this.age = 0;
        }
        public Student1(int id, string name, int age) : this(id,name)   //calling constructor from another cnstructor
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Student1(int id, string name)    
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Student1(Student1 s)
        {
            this.id = s.id;
            this.name = s.name;
            Console.WriteLine("Constructor with two parameters called");
        }
        public void Display()
        {
            Console.WriteLine($"Id: {id} Name: {name} Age:{age}");
        }
        static void Main(string[] args)
        {
            Student1 obj1 = new Student1(1, "AAA", 89); //Paramaterised Constructor
            obj1.Display();
            Student1 obj2 = obj1; //Copy Constructor
            obj2.Display();
        }
    }
}
