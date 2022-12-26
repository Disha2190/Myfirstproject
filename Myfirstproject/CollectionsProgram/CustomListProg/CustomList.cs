using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram
{
    class Student
    {
        public int id;
        public string name;
        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class CustomList
    {
        static void Main(string[] args)
        {
            List<Student> li = new List<Student>();
            li.Add(new Student(101, "Amit"));
            li.Add(new Student(102, "Nikita"));
            li.Add(new Student(103, "Yash"));
            foreach(Student s in li)
            {
                Console.WriteLine(s.id+" "+s.name);
            }
        }
    }
}
