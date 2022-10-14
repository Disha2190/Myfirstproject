using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class PrintNo
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5 == 0 || i%10 == 0)
                {
                    continue; 
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Loop3
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

    class While1
    {
        static void Main(string[] args)
        {
            int i = 1,k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k ="+k+" i ="+i);
        }
    }

    class SpyNum1
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

    class Trimorphic1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int cube = num * num * num;
            int a = cube % 10;
            if (temp == a)
            {
                Console.WriteLine("it is a trimorphic number");
            }
            else
            {
                Console.WriteLine("Not trimorphic");
            }
        }
    }

    class PaTtern1
    {
        static void Main(string[] args)
        {
            int z = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4-1; j >=i; j--)
                {
                    Console.Write(" ");
                }
                
                for(int k=0;k<z;k++)
                {
                    Console.Write(i);
                }
                z += 2;
                Console.WriteLine();
            }
        }
    }

    class PaTtern2
    {
        static void Main(string[] args)
        {
            int m = 1;
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j< m; j++)
                {
                    
                    Console.Write(" ");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                m++;
                Console.WriteLine();
            }
        }
    }

    class PaTtern3
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }


    class Task2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }

        }
    }

    class TwinPrime
    {
        static void Main(string[] args)
        {
            int count = 0, flag=0;
            Console.WriteLine("Enter two numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            for(int i=2;i<n1&&i<n2;i++)
            {
                if(n1%i==0)
                {
                    count++;
                    break;
                }
                if (n2 % i == 0)
                {
                    flag++;
                    break;
                }
            }
          

            if(count==0 && flag==0)
            {
                if(n1-n2==2 || n1-n2==-2)
                {
                    Console.WriteLine("Twin Prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }

    // 2 12 36 80 150 252 .......
    class Series3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10; i++)
            {
                int sum = i * i + i * i * i;
                Console.WriteLine(sum+" ");
            }
        }
    }

    class Task
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<= 50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                { 
                   int neg = i*(-1);
                    Console.WriteLine(neg+ " square= " +(neg*neg));
                }
            }
        }
    }
    class Task1
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }

        }
    }

    class Fibbonics
    {
        static void Main(string[] args)
        {
            int num = 20, a = 0, b = 1;
            
            for(int i=1;i<=num;i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }

    class Nthseries
    {
        static void Main(string[] args)
        {
            int sum = 0,fact=1;
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
          
           
                for(int j=1;j<=n;j++)
                {
                    fact = fact * j;
                    sum = sum + fact;

                }
            Console.WriteLine("Sum= "+sum);
        }
    }
}
