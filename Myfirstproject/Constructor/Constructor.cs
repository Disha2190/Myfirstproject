using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    //Constructor
    class Student4
    {
        int roll_no;
        String name;
        int marks;

        public Student4()
        {
            Console.WriteLine("Student is Initalised");
            roll_no = 0;
            name = "dummy";
            marks = 0;
        }
        public void display()
        {
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
        static void Main(string[] args)
        {
            Student4 stud = new Student4();
            stud.display();
            Console.ReadKey();
        }
    }

    class Student5
    {
        int roll_no;
        String name;
        int marks;

        public Student5(int roll_no, String name, int marks)
        {

            this.roll_no = roll_no;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
        static void Main(string[] args)
        {
            Student5 stud = new Student5(1, "Jeetu", 78);
            stud.display();

            Student5 stud1 = new Student5(2, "John", 88);
            stud.display();
            Console.ReadKey();
        }
    }

    class Student6
    {
        int roll_no;
        String name;
        int marks;

        public Student6(int roll_no, String name, int marks)
        {

            this.roll_no = roll_no;
            this.name = name;
            this.marks = marks;
        }
        public void Compare(Student6 stud)
        {
            if (marks > stud.marks)
            {
                display();
            }
            else
            {
                stud.display();
            }
        }
        public void display()
        {
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
        static void Main(string[] args)
        {
            Student6 stud = new Student6(1, "Harry", 78);


            Student6 stud1 = new Student6(2, "John", 88);
            stud.Compare(stud1);

            Console.ReadKey();
        }
    }

    class Calculation
    {
        public void add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("Addition of two integers: " + res);
        }

        public void add(int a)
        {
            int res = a + a;
            Console.WriteLine("Addition of 1 integer is: " + res);
        }
        public void add(double a, double b)
        {
            double res = a + b;
            Console.WriteLine("Addition of two double is: " + res);
        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation();
            obj.add(4, 5);
            obj.add(3);
            obj.add(4.5, 6.8);
        }
    }

    class Area
    {
        public void add(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("Area of rectangle: " + res);
        }

        public void add(int a)
        {
            int res = a * a;
            Console.WriteLine("Area of Square: " + res);
        }
        public void add(double a)
        {
            double res = 3.14 * a * a;
            Console.WriteLine("Area of Circle: " + res);
        }

        static void Main(string[] args)
        {
            Area obj = new Area();
            obj.add(4, 5);
            obj.add(3);
            obj.add(4.5);
        }
    }
    class Student7
    {
        int roll_no;
        String name;
        int marks;

        public Student7()
        {
            Console.WriteLine("This is deafult constructor");
        }
        public Student7(int roll_no, String name)
        {

            this.roll_no = roll_no;
            this.name = name;
        }
        public Student7(int roll_no, String name, int marks)
        {

            this.roll_no = roll_no;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }
        static void Main(string[] args)
        {
            Student7 stu = new Student7();
            stu.display();

            Student7 stud1 = new Student7(2, "John");
            stud1.display();

            Student7 stud = new Student7(1, "Harry", 78);
            stud.display(); Console.ReadKey();
        }

    }
    class GrossSalary
    {
        double hra;
        double da;
        double gross;
        public double salary { get; set; }

        public void Compare(double sa)
        {
            if (sa <= 10000)
            {
                hra = sa * 0.2;
                da = sa * 0.8;
            }
            else if (sa <= 20000)
            {
                hra = sa * 0.25;
                da = sa * 0.95;
            }
            else if (sa > 20000)
            {
                hra = sa * 0.3;
                da = sa * 0.95;
            }
            gross = sa + hra + da;
        }

        public void Display()
        {
            Console.WriteLine("Gross Salary is: " + gross);
        }
        static void Main(string[] args)
        {
            GrossSalary sal = new GrossSalary();
            Console.WriteLine("Enter the basic salary:");
            sal.salary = int.Parse(Console.ReadLine());
            sal.Compare(sal.salary);
            sal.Display();

        }
    }

    class Percentage
    {
        float p;
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Biology { get; set; }
        public int Mathematics { get; set; }
        public int Computer { get; set; }

        public void Perce(int Physics, int Chemistry, int Biology, int Mathematics, int Computer)
        {
            p = ((Physics + Chemistry + Biology + Mathematics + Computer) / 500.0f) * 100;
            Console.WriteLine("Percentage are: " + p);
        }

        public void Grade()
        {
            if (p >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (p >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (p >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (p >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else if (p < 50)
            {
                Console.WriteLine("Grade E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        static void Main(string[] args)
        {
            Percentage per = new Percentage();
            Console.WriteLine("Enter Physics Marks:");
            per.Physics = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Marks:");
            per.Chemistry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Biology Marks:");
            per.Biology = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Mathematics Marks:");
            per.Mathematics = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Computer Marks:");
            per.Computer = int.Parse(Console.ReadLine());

            per.Perce(per.Physics, per.Chemistry, per.Biology, per.Mathematics, per.Computer);
            per.Grade();
        }
    }

    class ElectricityBill
    {
        int units;
        double billpay = 0;
        public void Bill()
        {
            Console.WriteLine("Enter units consumed: ");
            int units = int.Parse(Console.ReadLine());
            if (units <= 50)
            {
                billpay = units * 0.50;
            }
            else if (units <= 150)
            {
                billpay = (50 * 0.50) + ((units - 50) * 0.75);
            }
            else if (units <= 250)
            {
                billpay = (50 * 0.50) + ((units - 50) * 0.75) + ((units - 150) * 1.20);
            }
            else if (units >= 250)
            {
                billpay = units * 1.50;
            }
            billpay = billpay + (billpay * 0.2);
            Console.WriteLine("Bill to pay: " + billpay);

        }

        static void Main(string[] args)
        {
            ElectricityBill Eb = new ElectricityBill();
            Eb.Bill();
        }
    }

    class MonthsDays
    {
        int days;
        public int month { get; set; }
        public void CountDays(int month)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 2:
                    days = 28;
                    break;
                deafult:
                    days = 0;
                    break;
            }
            if (days != 0)
            {
                Console.WriteLine("Number of days in " + month + " is: " + days);
            }
            else
            {
                Console.WriteLine("You have entered invalid month");
            }
        }
        static void Main(string[] args)
        {
            MonthsDays m = new MonthsDays();
            Console.WriteLine("Enter the month:");
            m.month = int.Parse(Console.ReadLine());
            m.CountDays(m.month);
        }
    }

    class Calculator
    {
        public int a { get; set; }
        public int b { get; set; }
        public char op { get; set; }
        public void Operation(int a, int b, char op)
        {
            switch (op)
            {
                case '+':
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(a * b);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(a / b);
                        break;
                    }
                default:
                    Console.WriteLine("invalid operator");
                    break;


            }
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("Enter the numbers:");
            c.a = int.Parse(Console.ReadLine());
            c.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation:");
            c.op = char.Parse(Console.ReadLine());
            c.Operation(c.a, c.b, c.op);
        }
    }

    class Denomination
    {
        public int cash { get; set; }
        public void Amount(int cash) // it will run without passing paramaters because get sedt method is in same class as
                                     // main method public void Amount()
        {
            while (cash >= 0)
            {
                if (cash >= 2000)
                {
                    Console.WriteLine("2000:" + (cash / 2000));
                    cash = cash % 2000;
                }
                else if (cash >= 500)
                {
                    Console.WriteLine("500:" + (cash / 500));
                    cash = cash % 500;
                }
                else if (cash >= 200)
                {
                    Console.WriteLine("200:" + (cash / 200));
                    cash = cash % 200;
                }
                else if (cash >= 100)
                {
                    Console.WriteLine("100:" + (cash / 100));
                    cash = cash % 100;
                }
                else if (cash >= 50)
                {
                    Console.WriteLine("50:" + (cash / 50));
                    cash = cash % 50;
                }
                else if (cash >= 20)
                {
                    Console.WriteLine("20:" + (cash / 20));
                    cash = cash % 20;
                }
                else if (cash >= 10)
                {
                    Console.WriteLine("10:" + (cash / 10));
                    cash = cash % 10;
                }
                else if (cash >= 1)
                {
                    Console.WriteLine("1:" + (cash / 1));
                    cash = cash % 1;
                }
            }
        }
        static void Main(string[] args)
        {
            Denomination d = new Denomination();
            Console.WriteLine("Enter the amount in rupees:");
            d.cash = int.Parse(Console.ReadLine());
            d.Amount(d.cash);
        }
    }
}
