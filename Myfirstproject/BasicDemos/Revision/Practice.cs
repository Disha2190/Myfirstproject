using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BasicDemos.Revision
{
    class OddNumSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                if (r % 2 != 0)
                {
                    sum += r;
                }
                n = n / 10;
            }
            Console.WriteLine("Sum of odd digits is: " + sum);
        }
    }

    class Palindrome01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n, rev = 0;
            while (n > 0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }

            if (temp == rev)
            {
                Console.WriteLine("The number " + temp + " is palindrom");
            }
            else
            {
                Console.WriteLine("The number " + temp + " is not palindrom");
            }
        }
    }

    class Table01
    {
        static void Main(string[] args)
        {
            int i = 1, n = 1, t = 1;
            while (i <= 10)
            {
                n = 1;
                while (n <= 10)
                {
                    t = i * n;
                    Console.Write(t + " ");
                    n++;
                }
                Console.WriteLine();
                i++;
            }

        }
    }

    class PrimeNo33
    {
        static void Main(string[] args)
        {
            int j, i = 1, n = 2, count = 0;
            while (i <= 100)
            {
                j = i / 2;
                n = 2;
                count = 0;
                while (n <= j)
                {
                    if (i % n == 0)
                    {
                        count = 1;
                        break;
                    }
                    n++;
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }

    class Students1
    {
        int age;
        String name;
        int id;

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
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
    }
    class StudentsDetails
    {
        static void Main(string[] args)
        {
            Students1 s = new Students1();
            s.Age = 17;
            s.Name = "John";
            s.Id = 33;

            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Id: " + s.Id);
            Console.WriteLine("Age: " + s.Age);
        }
    }

    class Students2
    {
        int id;
        String name;
        double percentage;

        public int Id { get; set; } //Auto Implement Property
        public String Name { get; set; }  //Auto Implement Property
        public double Percentage { get; set; }  //Auto Implement Property


    }
    class StudentsDetails2
    {
        static void Main(string[] args)
        {
            Students2 sd= new Students2();
            Students2 sd1 = new Students2();
            sd.Id = 2;
            sd.Name = "John";
            sd.Percentage = 99.23;
            Console.WriteLine("Name: " + sd.Name + " Id: " + sd.Id + " Percentage: " + sd.Percentage);

            sd1.Id = 3;
            sd1.Name = "Peter";
            sd1.Percentage = 92.53;
            Console.WriteLine("Name: " + sd1.Name + " Id: " + sd1.Id + " Percentage: " + sd1.Percentage);

            Console.WriteLine("Higheat Percentage");
            if (sd.Percentage>sd1.Percentage)
            {
                Console.WriteLine("Name: "+sd.Name+" Id: "+sd.Id+" Percentage: "+sd.Percentage);
            }
            else
            {
                Console.WriteLine("Name: " + sd1.Name + " Id: " + sd1.Id + " Percentage: " + sd1.Percentage);
            }
        }
    }

    class Students3
    {
        int id;
        String name;
        double marks;
        public int Id { get; set; }
        public String Name { get; set; }
        public double Marks { get; set; }

        public void Compare(Students3 s)
        {
            if (Marks > s.Marks)
                display();
            else
                s.display();
        }
        public void display()
        {
            Console.WriteLine("id: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Marks: "+Marks);
        }
    }
    class StudentsDetails3
    {
        static void Main(string[] args)
        {
            Students3 s = new Students3();
            s.Id = 1;
            s.Name = "John";
            s.Marks = 77.78;
            Students3 sd = new Students3();
            sd.Id = 2;
            sd.Name = "Peter";
            sd.Marks = 76.54;
            s.Compare(sd);

        }
    }

    class Employe
    {
        String name;
        int id;
        double salary;
        public String Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }
    }
    class EmployeDetails
    {
        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.Name = "John";
            e.Id = 1;
            e.Salary = 40000;
            Console.WriteLine("Name:" + e.Name + " Id:" + e.Id + " Salary:" + e.Salary);

            Employe ed = new Employe();
            ed.Name = "Peter";
            ed.Id = 2;
            ed.Salary = 50000;
            Console.WriteLine("Name:" + ed.Name + " Id:" + ed.Id + " Salary:" + ed.Salary);
            Console.WriteLine("Greatest Salary:");
            if (e.Salary>ed.Salary)
            {
                Console.WriteLine("Name:"+e.Name+" Id:"+e.Id+" Salary:"+e.Salary);
            }
            else
            {
                Console.WriteLine("Name:" + ed.Name + " Id:" + ed.Id + " Salary:" + ed.Salary);
            }
        }
    }

    class Time
    {
        int hr;
        int min;
        public int Hr { get; set; }
        public int Min { get; set; }

        public void Add3(Time t1,Time t2)
        {
            Hr = t1.Hr + t2.Hr;
            Min = t1.Min + t2.Min;
            if(Min>60)
            {
                Min = Min % 60;
                Hr++;
            }
        }
        public void Display()
        {
            Console.WriteLine("Time is "+Hr+" : "+Min);
        }
    }
    class TimeDetails
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            Time t2 = new Time();
            t1.Hr = 2;
            t1.Min = 26;
            t2.Hr = 4;
            t2.Min = 56;
            Time t3 = new Time();
            t3.Add3(t1, t2);
            t1.Display();
            t2.Display();
            t3.Display();
        }
    }


    class Time1
    {
        public int Hr { get; set; }
        public int Min { get; set; }

        public void Display()
        {
            Console.WriteLine("The time is"+Hr+" "+Min);
        }

        public Time1 Add1(Time1 t1,Time1 t2)
        {
            Time1 t = new Time1();
            t.Hr = t1.Hr + t2.Hr;
            t.Min = t1.Min + t2.Min;
            if(t.Min>=60)
            {
                t.Min = t.Min % 60;
                t.Hr++;
            }
            return t;
        }

    }
    class TimeDetails1
    {

        static void Main(string[] args)
        {
            Time1 t1 = new Time1();
            Time1 t2 = new Time1();
            t1.Hr = 2;
            t1.Min = 26;
            t2.Hr = 4;
            t2.Min = 56;
            Time1 t3 = new Time1();
            t3 = t3.Add1(t1, t2);
            t1.Display();
            t2.Display();
            t3.Display();
        }
    }

    class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Person Compare(Person p)
        {
            if(Age>p.Age)
            {
                return this;
            }
            else
            {
                return p;
            }
        }
    }
    class PersonDetails
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "John";
            p1.Age = 32;
            p2.Name = "Peter";
            p2.Age = 42;
            Person p3 = new Person();
            p3.Name = "Harry";
            p3.Age = 55;

            Person p = new Person();
            p = p1.Compare(p2);
            Console.WriteLine("Elder Person is " + p.Name + " having age "+p.Age);
            p = p1.Compare(p3);
            Console.WriteLine("Elder Person is " + p.Name + " having age "+p.Age);


        }
    }
    class Concat
    {
        public String name { get; set; }

        public Concat Add(Concat full)
        {
            full.name = name +" "+ full.name;
            return full;
        }
    }
    class ConcatDetails
    {
        static void Main(string[] args)
        {
            Concat first = new Concat();
            Concat Last = new Concat();
            first.name = "Harry";
            Last.name = "Potter";
            Concat full = new Concat();
            full = first.Add(Last);
            Console.WriteLine(full.name);
        }
    }

    class Concatname
    {
        public String name { get; set; }

        public Concatname Conc(Concatname n)
        {
            Concatname t = new Concatname();
            t.name = name + n.name;
            return t;
        }
    }

    class ConNameDetails
    {
        static void Main(string[] args)
        {
            Concatname n1 = new Concatname();
            Concatname n2 = new Concatname();
            n1.name = "Harry";
            n2.name = "Potter";
            Concatname n3 = new Concatname();
            n3 = n1.Conc(n2);
            Console.WriteLine("Concation name is: "+n3.name);
        }
    }


    

    class ConvDays
    {
        int years, weeks;
        public int days { get; set; }

        public void DaWeMo()
        {
            years = days / 365;
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.WriteLine("Years=" + years);
            Console.WriteLine("Weeks=" + weeks);
            Console.WriteLine("Days=" + days);
        }
        static void Main(string[] args)
        {
            ConvDays d = new ConvDays();
           Console.WriteLine("Enter number of Days:");
            d.days = int.Parse(Console.ReadLine());
            d.DaWeMo();
        }
    }

    class Toggle
    {
        public char ch { get; set; }
        public void Conversion()
        {
            int r;
            if (ch >= 65 && ch <= 90)
            {
                r = ch + 32;
                Console.WriteLine("Upper case charachter is:" +(char) r);
            }
            else
            {
                r = ch - 32;
                Console.WriteLine("Lower case character is: "+(char)r);
            }
        }
        static void Main(string[] args)
        {
            Toggle t = new Toggle();
            Console.WriteLine("Enter the character: ");
            t.ch = char.Parse(Console.ReadLine());
            t.Conversion();
        }
    }

    class CheckChar
    {
        public char ch { get; set; }
        public void Check()
        {
            if(ch>=65&&ch<=90)
            {
                Console.WriteLine((char)ch+" is uppercase charcter");
            }
            else if(ch>=97&&ch<=122)
            {
                Console.WriteLine((char)ch+" is lower case character");
            }
            else if(ch>=48 && ch<=57)
            {
                Console.WriteLine(ch+" is digit");
            }
            else
            {
                Console.WriteLine(ch+" is symbole");
            }
        }
        static void Main(string[] args)
        {
            CheckChar c = new CheckChar();
            Console.WriteLine("Enter the character: ");
            c.ch = char.Parse(Console.ReadLine());
            c.Check();
        }
    }

    class Even
    {
        public void check()
        {
            for(int i=121;i<=229;i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Even e = new Even();
            e.check();
        }
    }

    class Odd
    {
        public void Check()
        {
            for(int i=521;i>=229;i--)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Odd o = new Odd();
            o.Check();
        }
    }

    class Prime  //use of break
    {
        public void Prim()
        {
            int count = 1;
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    count = 0;
                    break;
                }
            }
            if(count==1)
            {
                Console.WriteLine(n+" is prime numner");
            }
            else
            {
                Console.WriteLine(n+" is not prime number");
            }
        }
        static void Main(string[] args)
        { 
            Prime p = new Prime();
            p.Prim();
        }
    }

    class AlpAtoZ
    {
        public void Print()
        {
            for(int i='a';i<='z';i++)
            {
                Console.WriteLine((char) i);
            }
        }
        static void Main(string[] args)
        {
            AlpAtoZ a = new AlpAtoZ();
            a.Print();
        }
    }

    class EvenSum
    {
        public void Sum()
        {
            int sum = 0;
            Console.WriteLine("Enter the range:");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if(i%2==0)
                {
                    sum+= i;
                }
            }
            Console.WriteLine("Sum of even numbers: "+sum);
        }
        static void Main(string[] args)
        {
            EvenSum e = new EvenSum();
            e.Sum();
        }
    }

    class OddSum
    {
        public void Sum()
        {
            int sum = 0;
            Console.WriteLine("Enter the range:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of odd numbers: " + sum);
        }
        static void Main(string[] args)
        {
            OddSum e = new OddSum();
            e.Sum();
        }
    }

    class NumDigit
    {
        public void Digits()
        {
            int count = 0;
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            while(n>0)
            {
                n = n / 10;
                count++;  
            }
            Console.WriteLine("Number of Digit in number "+temp+" are "+count);
        }
        static void Main(string[] args)
        {
            NumDigit a = new NumDigit();
            a.Digits();
        }
    }

    class FreqDigits
    {
        static void Main(string[] args)
        {

            int count = 0,r,t=0;
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <=9; i++)
            {
                count = 0;
                {
                    for (int j = num; j > 0; j = j / 10)
                    {
                        r = j % 10;

                        if (r == i)
                        {
                            t = i;
                            count++;
                        }
                    }
                    if(t==i)
                        Console.WriteLine("Frequency of number " + i + " is: " + count);
                }
            }
        }
    }

    class Prime1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers are: ");
            for (int i = 400; i >= 300; i--)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Power
    {

        static void Main(string[] args)
        {
            int power = 1;
            Console.WriteLine("Enter base: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Exponent: ");
            int ex = int.Parse(Console.ReadLine());

            for (int i = 0; i < ex; i++)
            {
                power = power * b;
            }
            Console.WriteLine("The power is: " + power);
        }
    }

    class Series   ///2 -4 6 -8
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms:");
            int n = int.Parse(Console.ReadLine());
            int i=2, c, f = 1;
            for(c=1;c<=n;c++)
            {
                if(f%2==0)
                {
                    Console.Write(-i+" ");
                }
                else
                {
                    Console.Write(i+" ");
                }
                i += 2;
                f++;
            }
        }
    }
    class Series1
    {
        static void Main(string[] args)
        {
            int j=1;
            Console.WriteLine("Enter the number of terms:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; j <= n;j++)
            {
                Console.Write(i+" ");
                i = i + j;
                
            }
        }
    }
}

