using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{
    abstract class Student1
    {
        public abstract void ShowStudent();
        public Student1(string name)
        {
            Console.WriteLine("Student: "+name);
        }
        public void DisplayMarks()
        {
            Console.WriteLine("Student Got firstclass");
        }
    }
    class Person1:Student1
    {
        public Person1():base("neha")
        {

        }
        public override void ShowStudent()
        {
            Console.WriteLine("Hi this is Student Info......");
        }
    }
    class AbstractClassDemo1
    {
        static void Main(string[] args)
        {
            Student1 s = new Person1();
            s.ShowStudent();
            s.DisplayMarks();
        }
    }
}
