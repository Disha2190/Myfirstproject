using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ArrayofObject
{
    class Student
    {
        int id;
        string name;
        int marks;
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
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        static void Main(string[] args)
        {
            Student[] stud= new Student[3];
            for(int i=0;i<stud.Length;i++)
            {
                stud[i] = new Student();
                Console.WriteLine("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks: ");
                int marks = int.Parse(Console.ReadLine());

                stud[i].Id = id;
                stud[i].Name = name;
                stud[i].Marks = marks;
            }
            Console.WriteLine("Id\tName\tMarks");
            for(int i=0;i<stud.Length;i++)
            {
                Console.WriteLine(stud[i].Id+"\t"+ stud[i].Name + "\t"+stud[i].Marks);
            }
        }
    }
    class Student1
    {
        int id;
        string name;
        int marks;
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
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        static void Main(string[] args)
        {
            Student1[] stud = new Student1[3];
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student1();
                Console.WriteLine("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks: ");
                int marks = int.Parse(Console.ReadLine());

                stud[i].Id = id;
                stud[i].Name = name;
                stud[i].Marks = marks;
            }
            Console.WriteLine("Id\tName\tMarks");
            foreach(Student1 s in stud)
            {
                Console.WriteLine(s.Id + "\t" + s.Name + "\t" + s.Marks);
            }
        }
    }
    class Student2
    {
        int id;
        string name;
        int marks;
        public Student2()
        {
            id = 0;
            name = "";
            marks = 0;
        }
        public Student2(int id,string name,int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine(id+"\t"+name+"\t"+marks);
        }
        static void Main(string[] args)
        {
            Student2[] stud = new Student2[3];
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student2();
                Console.WriteLine("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks: ");
                int marks = int.Parse(Console.ReadLine());

                stud[i] = new Student2(id, name, marks);
            }
            Console.WriteLine("Id\tName\tMarks");
            foreach(Student2 s in stud)
            {
                s.display();
            }
        }
    }
    class Employe
    {
        int id;
        string name;
        int salary;
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
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        static void Main(string[] args)
        {
            Employe[] emp = new Employe[3];
            for (int i = 0; i < emp.Length; i++)
            {
                //Created new object
                emp[i] = new Employe();
                Console.WriteLine("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary: ");
                int salary = int.Parse(Console.ReadLine());
                //Properties initialised
                emp[i].Id = id;
                emp[i].Name = name;
                emp[i].Salary = salary;
            }
            Console.WriteLine("Id\tName\tMarks");
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].Id + "\t" + emp[i].Name + "\t" + emp[i].Salary);
            }
        }
    }
    class Employe2
    {
        int id;
        string name;
        int salary;
        public Employe2()
        {
            id = 0;
            name = "";
            salary = 0;
        }
        public Employe2(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + "\t" + name + "\t" + salary);
        }
        static void Main(string[] args)
        {
            Employe2[] emp = new Employe2[3];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employe2();
                Console.WriteLine("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Salary: ");
                int salary = int.Parse(Console.ReadLine());

                emp[i] = new Employe2(id, name, salary);
            }
            Console.WriteLine("Id\tName\tSalary");
            foreach (Employe2 s in emp)
            {
                s.display();
            }
        }
    }

    class Demo
    {
        public void Add()
        {
            int a, b;
            a = 10;
            b = 20;
            int sum = a + b;
            Console.WriteLine("The sum is: "+sum);
        }
        public void Add1(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum is: "+sum);
        }
        public int Add2(int a,int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Add();
            d.Add1(23, 20);
            int sum= d.Add2(40, 2);
            Console.WriteLine("The addition is: "+sum);
        }
    }
}
