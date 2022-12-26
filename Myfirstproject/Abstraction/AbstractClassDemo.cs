using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Abstraction
{
    abstract class Student
    {
        public abstract void ShowStudent();
        public void DisplayMarks()
        {
            Console.WriteLine("Student Got firstclass");
        }
    }
    class Person: Student
    {
        public override void ShowStudent()
        {
            Console.WriteLine("HI this is student info........");
        }
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Student s = new Person();
            s.ShowStudent();
            s.DisplayMarks();
        }
    }
}
