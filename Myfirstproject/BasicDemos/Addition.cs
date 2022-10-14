using System;
using System.Collections.Generic;
using System.Text;

//Assignment 1

namespace Myfirstproject.BasicDemo
{ 
    class Addition
    {
        static void Main(string[]args)
        {
            int num1 = 30, num2 = 25;
            Console.WriteLine("Sum= " + (num1 + num2));
        }
    }

    class Subtraction
    {
        static void Main(string[]args)
        {
            int num1 = 10, num2 = 4;
            Console.WriteLine("Subtraction= " + (num1 - num2));

        }
    }

    class Multiplaction
    {
        static void Main(string[]args)
        {
            int num1 = 5, num2 = 4;
            Console.WriteLine("Multiplaction= " + num1 * num2);
        }
    }

    class Division
    {
        static void Main(string[]args)
        {
            int num1 = 4, num2 = 2;
            Console.WriteLine("Division= " + num1 / num2);
        }

    }

    class Rectangle
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the Length and Breadth: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Rectangle is: " + l * b);
        }
    }

    class Triangle
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter base and height of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Triangle is: " + ((b * h) / 2));
        }
    }

    class Square
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square of Number is: " + num * num);
        }
    }

    class Cube
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cube of number is: " + num * num * num);
        }
    }

   
}
