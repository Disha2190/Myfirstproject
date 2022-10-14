using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BasicDemos
{
    class LeapYear
    {
       static void Main(string[]args)
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
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if(num%5==0 && num%11==0)
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
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the Number:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine(num1 + " is the greatest number");
            }
            else if(num2>num3)
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
        static void Main(string[]args)
        {
            Console.WriteLine("Entar the character: ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c=='a'||c=='e'||c=='i' || c=='o' || c=='u')
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

        class PostNegtZero
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    Console.WriteLine(num + " is Positive number");
                }
                else if (num <= 0)
                {
                    Console.WriteLine(num + "is negative number");
                }
                else
                {
                    Console.WriteLine(num + "is Zero");
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


    

    class Denomination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount in rupees:");
            int cash = int.Parse(Console.ReadLine());

            Console.WriteLine("2000:" + (cash / 2000));
            cash = cash % 2000;

            Console.WriteLine("500:" + (cash / 500));
            cash = cash % 500;

            Console.WriteLine("200:" + (cash / 200));
            cash = cash % 200;

            Console.WriteLine("100:" + (cash / 100));
            cash = cash % 100;

            Console.WriteLine("50:" + (cash / 50));
            cash = cash % 50;

            Console.WriteLine("20:" + (cash / 20));
            cash = cash % 20;

            Console.WriteLine("10:" + (cash / 10));
            cash = cash % 10;

            Console.WriteLine("1:" + (cash / 1));
            cash = cash % 1;


        }
    }

    class GrossSalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary:");
            double Basicsalary = double.Parse(Console.ReadLine());
            if (Basicsalary <= 10000)
            {
                Console.WriteLine("Gross Salary: " + (Basicsalary + 20 + 80));
            }
            else if (Basicsalary <= 20000)
            {
                Console.WriteLine("Gross Salary: " + (Basicsalary + 25 + 90));
            }
            else if (Basicsalary > 20000)
            {
                Console.WriteLine("Gross Salary: " + (Basicsalary + 30 + 95));
            }
        }
    }

    class ThreeDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if(num>99 && num<1000)
            {
                Console.WriteLine(num+ " is 3 digit number");
                int x = num / 100;
                int y = num % 10;
                int sum = x + y;
                Console.WriteLine("Last two digit sum is: " +sum);
            }
        }
    }

    class SimpleCalculator1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operation: \n 1.Addition \n 2.Subtraction \n 3.Division \n 4.Multiplication  ");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                        Console.WriteLine("Addition: " + (num1 + num2));
                        break;

                case 2:
                    Console.WriteLine("Subtraction: "+(num1-num2));
                    break;

                case 3:
                    Console.WriteLine("Division: " +(num1/num2));
                    break;

                case 4:
                    Console.WriteLine("Multiplication: " +(num1*num2));
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
             }
        }
    }

    class  Days
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Days:\n 1.Monday \n 2.Tuesday \n 3.Wednesday \n 4.Thursday \n 5.Friday \n 6.Saturday \n 7.Sunday");
            int op = int.Parse(Console.ReadLine());
            
            switch(op)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid Opttion");
                    break;


            }
        }
    }

    class Days1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Days:\n 1.Monday \n 2.Tuesday \n 3.Wednesday \n 4.Thursday \n 5.Friday \n 6.Saturday \n 7.Sunday");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Error, day does not exist ");
                    break;


            }
        }
    }


    class Num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: \n 1 \n 2 \n 3 \n 4 \n 5");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: 
                        Console.WriteLine("One");
                        break;
                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;

                case 5:
                    Console.WriteLine("Five");
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        }
    }


    class Area1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operation: 1.Area of circle \n 2.Area of square \n 3.Area of right angled triangle \n 4.Area of rectangle \n 5.Circumference of circle \n 6.Perimeter of square");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("Enter radius of circle:");
                    float r = float.Parse(Console.ReadLine());
                    Console.WriteLine("Radius of circle:" +(3.14*r*r));
                    break;
                case 2:
                    Console.WriteLine("Enter side: ");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square: " +(side*side));
                    break;
                case 3:
                    Console.WriteLine("Enter Base:");
                    int Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height:");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of right angled triangle: "+((Base*height)/2));
                    break;
                case 4:
                    Console.WriteLine("Enter Width:");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length:");
                    int length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle: " +(width*length));
                    break;
                case 5:
                    Console.WriteLine("Enter radius of circle:");
                    float rd = float.Parse(Console.ReadLine());
                    Console.WriteLine("Circumference of circle is: " +(2*3.14*rd));
                    break;
                case 6:
                    Console.WriteLine("Enter side:");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter of square: " +(4*side1));
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;

            }
        }
    }

    class Days2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Days:\n 1.Monday \n 2.Tuesday \n 3.Wednesday \n 4.Thursday \n 5.Friday \n 6.Saturday \n 7.Sunday");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Error, day does not exist ");
                    break;


            }
        }
    }

    class Area2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'C':
                    Console.WriteLine("Enter radius of circle:");
                    float r = float.Parse(Console.ReadLine());
                    Console.WriteLine("Radius of circle:" + (3.14 * r * r));
                    break;
                case 'S':
                    Console.WriteLine("Enter side: ");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square: " + (side * side));
                    break;
                case 'T':
                    Console.WriteLine("Enter Width:");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length:");
                    int length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle: " + (width * length));
                    break;

            }
        }
    }
}
