using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BasicDemos
{
    class ArithmeticOperations
    {
        static void Main(string[]args)
        {
            int num1=20, num2=10;
           
            Console.WriteLine("Addition=" +(num1+num2));
            Console.WriteLine("subtraction=" +(num1-num2));
            Console.WriteLine("Multiplication=" +num1 * num2);
            Console.WriteLine("Divison=" +num1 / num2);
        }

    }

    class Cube
    {
        static void Main(string[]args)
        {
            int cube = 3;
            Console.WriteLine(cube * cube * cube);
        }
    }

    class swapping
    {
        static void Main(string[] args)
        {
            int a = 5, b = 3, swap;

            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("After Swapping a=" + a + ", b=" + b);
        }
    }

    class Percentage
    {
        static void Main(string[]args)
        {
            float Per;
            Console.WriteLine("Enter the Marks of five subjects:");
            int Maths= Convert.ToInt32(Console.ReadLine());
            int English=Convert.ToInt32(Console.ReadLine());
            int Science=Convert.ToInt32(Console.ReadLine());
            int Physics=Convert.ToInt32(Console.ReadLine());
            int Chemistry=Convert.ToInt32(Console.ReadLine());

            Per = ((Maths + English + Science + Physics + Chemistry) / 500.0f) * 100;
                
            Console.WriteLine("The Percentage is: " + Per+"%");


        }
    }
}
