using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class Course
    {
        private int id;
        private string name;
        private double fees;
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
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }
        static void Main(string[] args)
        {
            //Property Initializer Syntax
            Course c1 = new Course();
            c1.Id = 1;
            c1.Name = "c#";
            c1.Fees = 20000;
            Console.WriteLine($"Id {c1.Id} {c1.Name} {c1.Fees}");

            //object Initializew Syntax
            Course c2 = new Course {Id = 2, Name = "Java", Fees = 20000 };
            Console.WriteLine($"Id {c2.Id} {c2.Name} {c2.Fees}");
        }
    }
}
