using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Encapsulation
{
    class Students
    {
        int id;
        String name;
        int marks;
        bool result;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Marks
        {
            set
            {
                marks = value;
            }
            get
            {
                return marks;
            }
        }

        public bool Result
        {
            set
            {
                result = value;
            }
            get
            {
                return result;
            }
        }
    }

    class StudentInfo
    {
         static void Main(string[] args)
         {
                Students sd = new Students();
                sd.Id = 1;
                sd.Name = "John";
                sd.Marks = 79;
                sd.Result = true;

                Console.WriteLine("Id: "+sd.Id);
                Console.WriteLine("Name: "+sd.Name);
                Console.WriteLine("Marks: "+sd.Marks);
                Console.WriteLine("Result: "+sd.Result);
         }
    }

    class Student1
    {
        int id;
        string name;
        int age;
        public void GetInfo()
        {
            id = 1;
            name = "Rajesh";
            age = 34;
        }
        public void GetInfo(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void PutInfo()
        {
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }
        static void Main(string[] args)
        {
            Student1 sd = new Student1();
            sd.GetInfo();
            sd.PutInfo();
            Student1 sd1 = new Student1();
            sd1.GetInfo(2,"Girish",45);
            sd1.PutInfo();
        }
    }
}
