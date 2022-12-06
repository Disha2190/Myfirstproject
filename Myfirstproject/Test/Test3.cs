using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Test
{
    class Iterates
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 && i%10==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class EvenOddSquare
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i*i);
                }
            }
        }
    }

    class FibboSeries
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            for(int i=1;i<=20;i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }
        }
    }

    class Harshad2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0,temp=n;
            
            while(n>0)
            {
                int r = n % 10;
                sum += r;
                n = n / 10;
            }
            
            if(temp%sum==0)
            {
                Console.WriteLine("Harshad number");
            }
            else
            {
                Console.WriteLine("Not harshad Number");
            }
        }
    }

    class RedBlue
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("ReadBLue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Order
    {
        int order_id;
        String city;
        String cust_name;
        String isDelivered;

        static void Main(string[] args)
        {
            Order od = new Order();
            od.order_id = 2;
            od.city = "Mumbai";
            od.cust_name = "Priya";
            od.isDelivered = "yes";
            Console.WriteLine("Id:"+od.order_id+" City Name:"+od.city+" Customer Name:"+od.cust_name+" Delivered:"+od.isDelivered);
        }
    }


    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int temp = n,sum=0;

            while(n>0)
            {
                int r = n % 10;
                int fact = 1;
                for(int i=1;i<=r;i++)
                {
                    fact=fact*i;
                }
                sum = sum + fact;
                n = n / 10;
            }
            
            if(sum==temp)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy");
            }
        }
    }
}
