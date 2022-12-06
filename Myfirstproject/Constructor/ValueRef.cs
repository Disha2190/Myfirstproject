using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class ValueRef  //Call by Value and Call by Reference
    {
        static void Swap(int x, int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine("Inside Function : First: "+x+ " Second: "+y);
        }
        static void Swap1(ref int x,ref int y)
        {
            int t = x;
            x = y;
            y = t;
            Console.WriteLine("Inside Function : First: " + x + " Second: " + y);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Call by value:");
            a = 8;
            b = 4;
            Console.WriteLine("Before Function : First: " + b + " Second: " + b);
            Swap(a, b);
            Console.WriteLine("After Function : First: " + b + " Second: " + b);
            Console.WriteLine("Call by Reference:");
            a = 8;
            b = 4;
            Console.WriteLine("Before Function : First: " + b + " Second: " + b);
            Swap1(ref a,ref b);
            Console.WriteLine("After Function : First: " + b + " Second: " + b);
        }
    }
}
