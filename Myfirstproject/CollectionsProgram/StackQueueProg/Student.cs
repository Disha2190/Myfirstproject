using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.CollectionsProgram.StackQueueProg
{
    class Student
    {
        public int id;
        public string name;
        public int marks;
        public Student(int id,string name,int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
    }
    class StudentsDetails
    {
        static void Main(string[] args)
        {
            Queue<Student> q = new Queue<Student>();
            q.Enqueue(new Student(1, "Harry", 74));
            q.Enqueue(new Student(2, "Jack", 85));
            q.Enqueue(new Student(3, "Peter", 55));
            q.Enqueue(new Student(4, "Ron", 78));
            foreach(var x in q)
            {
                if(x.marks>60)
                {
                    Console.WriteLine(x.id+" "+x.name+" "+x.marks);
                }
            }
        }
    }
}
