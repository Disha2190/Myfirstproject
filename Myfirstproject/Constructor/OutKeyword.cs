using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Constructor
{
    class OutKeyword
    {
        public static void arithmetic(int x,int y,out int a, out int s, out int m,out int d)
        {
            a = x + y;
            s = x - y;
            m = x * y;
            d = x / y;
        }
        static void Main(string[] args)
        {
            int a, b, add, sub, mul, div;
            Console.WriteLine("Enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = int.Parse(Console.ReadLine());
            arithmetic(a, b, out add, out sub, out mul, out div);
            Console.WriteLine("Addition is: "+add);
            Console.WriteLine("Subtraction is: " + sub);
            Console.WriteLine("Multiplication is: " + mul);
            Console.WriteLine("Division is: " + div);
        }
    }
    class Ope
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10;
            int c = a + b++;
            Console.WriteLine(a+" "+b+" "+c);
            c = a + (++b);
            Console.WriteLine(a+" "+b+" "+c);
        }
    }
}
