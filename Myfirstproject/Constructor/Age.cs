using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class Age  //Using Reference value
    {
        static void Age1(ref int age,int year)
        {
            age += year;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int yr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Age1(ref age, yr);
            Console.WriteLine("The age is: "+age);
        }
    }
    class Operator
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++ +" "+ a++ +" "+ ++a);
            a = 5;
           int b= 2,c;
            c = a * b+ (a++ + --b) - b;
            Console.WriteLine(a+ " "+b+" "+c);
        }
    }
}
