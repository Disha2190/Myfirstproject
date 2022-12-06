using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class DisplayNo1
    {
        static void Main(string[] args)
        {
            int i = 35;
            while (i <= 75)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

    class DisplayNo2
    {
        static void Main(string[] args)
        {
            int i = 60;
            while (i <= 25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }

    class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0, rev;
            while (num > 0)
            {
                rev = num % 10;
                sum = sum * 10 + rev;
                num = num / 10;
            }

            if (num1 == sum)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
    }

    class SpyNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, pro = 1;
            while (num > 0)
            {
                int a = num % 10;
                sum += a;
                pro = pro * a;
                num = num / 10;
            }

            if (pro == sum)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine("Not Spy number");
            }
        }
    }

    class MagicNumber1
    {
        static void Main(string[] args)
        {
            int Magic_Number = 55;

            while (true)
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());

                if (num < Magic_Number)
                {
                    Console.WriteLine("Number is smaller pls try again..");
                    continue;
                }
                else if (num > Magic_Number)
                {
                    Console.WriteLine("Number is greater pls try again..");
                    continue;
                }
                else
                {
                    Console.WriteLine("guessing number is correct.......Thank You");
                    break;
                }
            }
        }
    }

    class Amstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three digit number:");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
          
            if(temp==sum)
            {
                Console.WriteLine(temp+" is a Amstrong number");
            }
            else
            {
                Console.WriteLine(temp+" is not Amstrong number");
            }
        }
    }

    class Power3
    {
        static void Main(string[] args)
        {
            int c = 1;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while(b>0)
            {
                c = c * a;
                b--;
            }
            Console.WriteLine(c);
        }
    }
}
