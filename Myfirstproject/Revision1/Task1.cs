using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Revision1
{
    class Task1  //Positive and negative number
    {
        int a;
        public void Accept()
        {
            Console.WriteLine("Enter number:");
            a = int.Parse(Console.ReadLine());
        }
        public void Check()
        { 
            if(a>0)
            {
                Console.WriteLine($"{a} is positive number");
            }
            else
            {
                Console.WriteLine($"{a} is a negative number");
            }
        }
        static void Main(string[] args)
        {
            Task1 obj = new Task1();
            obj.Accept();
            obj.Check();
        }
    }

    class Task2  //Even Odd number
    {
        int a;
        
        public void Accept()
        {
            Console.WriteLine("Enter the number:");
            a = int.Parse(Console.ReadLine());
        }
        public void Check()
        {
            if(a%2==0)
            {
                Console.WriteLine($"{a} is Even number");
            }
            else
            {
                Console.WriteLine($"{a} is Odd number");
            }
        }
        static void Main(string[] args)
        {
            Task2 obj = new Task2();
            for (int i = 0; i < 5; i++)
            {
                obj.Accept();
                obj.Check();
            }
        }
    }
    class Task3  // Sum of Natural number
    {
        int a;
        public void Accept()
        {
            Console.WriteLine("Enter range of natural number:");
            a = int.Parse(Console.ReadLine());
        }
        public int Sum()
        {
            /* int sum = 0;
             for (int i = 1; i <= a; i++)
             {
                 sum += i;
             }
             return sum;
            */
            int sum = a * (a + 1) / 2;
            return sum;
        }
        public void Display()  // Used Nested Method
        {
            Console.WriteLine("Sum is: "+Sum());
        }
        static void Main(string[] args)
        {
            Task3 obj = new Task3();
            obj.Accept();
            obj.Display();
        }
    }

    class Task4  // Sum of numbers in Range
    {
        int a, b;
        public void Accept()
        {
            Console.WriteLine("Entr First number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Last number:");
            b = int.Parse(Console.ReadLine());
        }
        public int Sum()
        {
            /*int sum = 0;
            for(int i=a;i<=b;i++)
            {
                sum += i;
            }
            return sum;
            */
            int sum = (b * (b + 1) / 2)- (a * (a + 1) / 2) + a;
            return sum;
        }
        public void Display()
        {
            Console.WriteLine("Sum is:"+Sum());
        }
        static void Main(string[] args)
        {
            Task4 obj = new Task4();
            obj.Accept();
            obj.Display();
        }
    }
    class Task5 //Greatest of two number
    {
        int a, b;
        public void Accept()
        {
            Console.WriteLine("Enter number 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            b = int.Parse(Console.ReadLine());
        }
        public int Check()
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public void Display()
        {
            Console.WriteLine("Greatest number is: "+Check());
        }
        static void Main(string[] args)
        {
            Task5 obj = new Task5();
            obj.Accept();
            obj.Display();
        }
    }
}
