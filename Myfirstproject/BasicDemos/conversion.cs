using System;
using System.Collections.Generic;
using System.Text;

//Assignment 1

namespace Myfirstproject.BasicDemos
{
    class conversion
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the Length in centimeter : ");
            float length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Length in meter: " +length/100+"m");
            Console.WriteLine("Length in Kilometer: " +length/100000+"km");
        }
    }

    class Marks
    {
        static void Main(string[] args)
        {
            float Per;
            Console.WriteLine("Enter the Marks of five subjects:");
            int Maths = Convert.ToInt32(Console.ReadLine());
            int English = Convert.ToInt32(Console.ReadLine());
            int Science = Convert.ToInt32(Console.ReadLine());
            int Physics = Convert.ToInt32(Console.ReadLine());
            int Chemistry = Convert.ToInt32(Console.ReadLine());
            
            int total = Maths + English + Science + Physics + Chemistry;

            float average = total / 5;

            Per = (total / 500.0f) * 100;

            Console.WriteLine("Total marks are: " + total);
            Console.WriteLine("Average of marks: " + average);
            Console.WriteLine("The Percentage are: " + Per + "%");
        }
    }

    class SimpleIntrest
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the principal, rate, time period: ");
            int principal = Convert.ToInt32(Console.ReadLine());
            float rate = Convert.ToSingle(Console.ReadLine());
            int TimePeriod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Simple Intrest= " + (principal * rate * TimePeriod) / 100);
        }
    }

    class RectPerimeter
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter length and breadth: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perimeter of rectangle= " + (length + breadth) * 2);
        }
    }

    class AreaEquilateralaTri
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter side of trinagle:");
            int side = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Equilateral Triangle: " + (1.73 * side * side) / 4);
        }
    }

    class Expression
    {
        static void Main(string[] args)
        {
            double exp = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));

            Console.WriteLine("Ans= " + exp);
        }

    }

    class SpExpression
    {
        static void Main(string[]args)
        {
            double exp = 4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11));

            Console.WriteLine("Ans= " + exp);
        }
    }

    class CtoF
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter temperature in Celcius: ");
            float C = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Temperature in Farenheit: " + ((C * 1.8) + 32)+"F");
        }
    }

    class FtoC
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter temperature in Farenheit: ");
            float F = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Temperature in Celcius: " + ((F - 32) / 18000)+"C");
        }
    }
}
