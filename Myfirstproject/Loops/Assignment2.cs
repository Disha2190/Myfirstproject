using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class EvenNum
    {
        static void Main(string[] args)
        {
            for(int i=121;i<=229;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class OddNum
    {
        static void Main(string[] args)
        {
            int i = 521;
            
            while(i>=229)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }

    class PrimeBreak
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    count++;
                    break;
                }
            }

            if(count==0)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }

    class GcdLcm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

        }
    }

    class AtoZ
    {
        static void Main(string[] args)
        {
            for(char c='a'; c<='z'; c++)
            {
                Console.WriteLine(c);
            }
        }
    }

    class EvenSum1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1;i<=num;i++)
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum= " +sum);

        }
    }
    class OddSum1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum= " + sum);

        }
    }

    class NumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int i = 1;
            do
            {
                num = num / 10;
                count++;
                //Console.WriteLine(count);
            } while (i <= num);
            Console.WriteLine("Number of Digits are: " +count);

           /* for(i=1;i<=num;i++)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Numbers of Digit: " +count);*/
        }
    }

    class ProductOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int product = 1;
            for(int i=1;i<=num;i++)
            {
                int a = num % 10;
                product = product * a;
                num = num / 10;
            }
            Console.WriteLine("Product= "+product);
        }
    }

    class FreqDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            //int temp = num;
           for(int i=0;i<10;i++)
            {
                Console.WriteLine("Frequency of number "+i+" is: ");
                int count = 0;
                {
                    for(int j=num;j>0;j=j/10)
                    {
                        int r = num % 10;
                      
                        if(r==i)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                }
            }
        }
    }

    class Prime400tO300
    {
        static void Main(string[] args)
        {
           //int count = 0;
            Console.WriteLine("Prime numbers are: ");
            for (int i = 400; i >= 300; i--)
            {
                //bool isPrime = true;
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        //isPrime = false;
                        count++;
                        break;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Table1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for table: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num+"*"+i+"="+(num*i));
            }
        }
    }

    class Square
    {
        static void Main(string[] args)
        {
            int square;
            for (int i = 1; i <= 20; i++)
            {
                square = i * i ;
                Console.WriteLine(square);
            }
        }
    }

    class Power1
    {
        static void Main(string[] args)
        {
            int power = 1;
            Console.WriteLine("Enter the base: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index: ");
            int index = int.Parse(Console.ReadLine());

            while(index!=0)
            {
                power = power * index;
                --index;
            }
            Console.WriteLine(power);
        }
    }
   
    class FactSerSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0,fact= 1;

            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
                sum += fact;
            }
            Console.WriteLine("Sum= " +sum);
        }
    }
    
    class Krishnamurthy1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1, sum = 0;
            int temp = n;
            while(n>0)
            {
                int r = n % 10;
                for(int i=1;i<=n;i++)
                {
                    fact = fact * i;
                }
                sum += fact;
                n = n / 10;
            }
            Console.WriteLine("Sum= "+sum);

            if (temp == sum)
            {
                Console.WriteLine("Krishnamurthy");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy");
            }
        }
    }

    class Palindrom1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int temp = n,rev=0;
            while(n>0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            
            if(temp==rev)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
    }

    class Automorphic1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = n;
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            n = temp;

            int square = n * n;
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            int rev = square % power;
            if(n==rev)
            {
                Console.WriteLine("Automrphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }
        }
    }

    class Harshad1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, count = 0;
            int temp = n;
            while(n>0)
            {
                int r = n % 10;
                sum += r;
                n = n / 10;
                count++;
            }
            
            if(sum%count==0)
            {
                Console.WriteLine("Harshad");
            }
            else
            {
                Console.WriteLine("Not Harshad");
            }
        }
    }

    class PalindromSer
    {
        static void Main(string[] args)
        {
            int rev = 0;
            for(int i=100;i<=500;i++)
            {
                while (i > 0)
                {
                    int r = i % 10;
                    rev = rev * 10 + r;
                    i = i / 10;
                }
                if(i==rev)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}