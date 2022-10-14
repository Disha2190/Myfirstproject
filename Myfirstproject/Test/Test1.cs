using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class AreaEquilateralaTri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of trinagle:");
            int side = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Equilateral Triangle: " + (1.73 * side * side) / 4);
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

    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && ((year % 400 == 0) || (year % 100 != 0)))
            {
                Console.WriteLine("Year is Leap Year: " + year);
            }
            else
            {
                Console.WriteLine("Year is not Leap year");
            }
        }
    }

    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("The Number " + num + " is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("The Number " + num + " is not divisible by 5 & 11");
            }
        }
    }

    class Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the greatest number");
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + " is the greatest number");
            }
            else
            {
                Console.WriteLine(num3 + " is the greatest number");
            }

        }
    }

    class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entar the character: ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine(c + " is Vowel");
            }
            else
            {
                Console.WriteLine(c + "is Consonant");
            }
        }
    }

    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Operation: \n 1.Addition\n 2.Subtraction \n 3.Multiplication \n 4.Division");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Addition= " + (num1 + num2));
            }
            else if (op == 2)
            {
                Console.WriteLine("Subtraction= " + (num1 - num2));
            }
            else if (op == 3)
            {
                Console.WriteLine("Multiplication= " + (num1 * num2));
            }
            else if (op == 4)
            {
                Console.WriteLine("Division= " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }

    class CheckChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is Digit");
            }
            else
            {
                Console.WriteLine(ch + " is Special Charcter");
            }
        }
    }

    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even number");
            }
            else
            {
                Console.WriteLine(num + "is odd number");
            }
        }
    }

}
