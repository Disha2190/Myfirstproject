using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BasicDemos
{
    class ConvDays
    {
        static void Main(string[]args)
        {
            int years, weeks;
            Console.WriteLine("Enter number of Days:");
            int days = int.Parse(Console.ReadLine());
            years = days/365;
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.WriteLine("Years=" + years);
            Console.WriteLine("Weeks=" + weeks);
            Console.WriteLine("Days=" + days);
        }
    }

    class PostNegt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine(num + " is Positive number");
            }
            else
            {
                Console.WriteLine(num + "is negative number");
            }
        }
    }

    class Age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Friends age: ");
            int age2 = int.Parse(Console.ReadLine());
            if(age1>age2)
            {
                Console.WriteLine("Hii!");
            }
            else if(age1<age2)
            {
                Console.WriteLine("Hello!");
            }
            else
            {
                Console.WriteLine("HiFi!");
            }
        }
    }

    class AssignClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks:");
            
            Console.WriteLine("Maths=");
            int maths = int.Parse(Console.ReadLine());
            
            Console.WriteLine("English=");
            int english = int.Parse(Console.ReadLine());

            Console.WriteLine("Science="); 
            int science = int.Parse(Console.ReadLine());

            Console.WriteLine("Social Science=");
            int socialscience = int.Parse(Console.ReadLine());

            Console.WriteLine("Physics=");
            int physics = int.Parse(Console.ReadLine());

            float percentage= ((maths + english + science + socialscience + physics) / 500.0f)*100;
            Console.WriteLine("Total Percentag= " +percentage);

            if(percentage>=70)
            {
                Console.WriteLine("Distinction");
            }
            else if(percentage<70 && percentage>=60)
            {
                Console.WriteLine("First Class");
            }
            else if(percentage>=50 && percentage<60)
            {
                Console.WriteLine("Second Class");
            }
            else if(percentage>=35 && percentage<50)
            {
                Console.WriteLine("Pass");
            }
            else if(percentage<35)
            {
                Console.WriteLine("Fail");
            }

        }
    }

    class Age1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Friends age: ");
            int age2 = int.Parse(Console.ReadLine());
            if (age1 > age2)
            {
                Console.WriteLine("Hii!");
            }
            else if (age1 < age2)
            {
                Console.WriteLine("Good Morning!");
            }
            else
            {
                Console.WriteLine("How are you!");
            }
        }
    }

    class Div
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if(num%3==0 && num%9==0)
            {
                Console.WriteLine("Divisible by 3 and 9");
            }
            else
            {
                Console.WriteLine("Not Divisible by 3 nd 9");
            }
        }
    }

    class TerPosNeg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

           string x= num >= 0 ? "num is Positive" : "num is negative";

            Console.WriteLine(x);
        }
    }

    class TerEvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());

            string x = num % 2 == 0 ? "num is Even" : "num is Odd";
            Console.WriteLine(x);
        }
    }
}
