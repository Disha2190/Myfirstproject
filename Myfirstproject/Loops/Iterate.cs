using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class Iterate
    {
        static void Main(string[] args)
        {
           for(int i=1; i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Reverse
    {
        static void Main(string[] args)
        {
            for(int i=10; i>=1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Elements
    {
        static void Main(string[] args)
        {
            /*for(int i=1; i<20; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }*/
            for(int i=1;i<20;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Elements1
    {
        static void Main(string[] args)
        {
            /* for (int i = 1; i < 20; i++)
             {
                 if (i % 2 != 0)
                 {
                     Console.WriteLine(i);
                 }
             }*/
            for (int i = 2; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }


    class Power
    {
        
        static void Main(string[] args)
        {
            int power = 1;
            Console.WriteLine("Enter base: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Exponent: ");
            int ex = int.Parse(Console.ReadLine());

            for(int i=0; i<ex; i++)
            {
               power= power * b;
            }
            Console.WriteLine("The power is: " + power);
        }
    }

    class Factorial
    {
        static void Main(string[] args)
        {
            int fact=1;
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=num; i>1; i--)
            {
                fact=fact*i ;
                
            }
            Console.WriteLine("Factorial = " + fact);
        }
    }

    class Sum1
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int i=1;i<=10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum= " +sum);
        }
    }

    class SumEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i<=30; i++)
            {
                if(i%2==0)
                {
                    sum += i;
                }

            }
            Console.WriteLine("Sum= "+sum);
        }
    }

    class Elements2
    {
        static void Main(string[] args)
        {
            int a = 1;
            for(int i=1; i<=20; i+=i+1)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Elements3
    {
        static void Main(string[] args)
        {
            int a;
            for(int i=1; i<=10; i++)
            {
                a = i * i;
                Console.WriteLine(a);
            }
        }
    }

    class Table
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("Enter the number for table: ");
            int a = int.Parse(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(a+"*"+i+ "=" +(a*i));
            }
        }
    }

    class CountOdd
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2!=0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    class DispNum
    {
        static void Main(string[] args)
        {
            for(int i=120;i<175;i++)
                Console.WriteLine(i);
        }
    }

    class AltEven
    {
        static void Main(string[] args)
        {
            for (int i=2;i<=20;i=i+4)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Series
    {
        static void Main(string[] args)
        {
            int ans;
            for (int i = 1; i <= 10; i++)
            {
                ans = i * i * i;
                Console.WriteLine(ans);
            }
        }
    }

    class Series1
    {
        static void Main(string[] args)
        {
            int ans;
            for (int i = 1; i <= 10; i++)
            {
                ans = (i * i * i)-1;
                Console.WriteLine(ans);
            }
        }
    }

    class MagicNumber
    {
        static void Main(string[] args)
        {
            int Magic_Number = 55;

            for(; ; )
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

    class EvenDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int a;
            for (int i = 1; i <= num; i++)
            {
                a = num % 10;
                num = num / 10;
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }

    class EvenFiAnLa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, k=0;
            int r = num % 10;

            for (int i=1;i<=num;i++)
            {
                int a = num % 10;

                num = num / 10;

                k = num;
            }

            Console.WriteLine("Sum of first and last digit is: " +(r+k));
        }
    }

    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int cube = num * num * num;
            int a = cube % 10;
            if(temp==a)
            {
                Console.WriteLine("it is a trimorphic number");
            }
            else
            {
                Console.WriteLine("Not trimorphic");
            }
        }
    }

    class AverageDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0,count=0;
            for(int i=1;i<=num;i++)
            {
                int r = num % 10;
                sum += r;
                count++;
                num = num / 10;
                
            }
            //float avg = sum / count;
            Console.WriteLine("Average of digits is: "+(sum/count));
        }
    }

    class Table1to5
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Table of " + i + " is: ");

                for (int j=1;j<=10;j++)
                {
                    Console.WriteLine(j*i);
                }
            }
        }
    }

    class FactOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while(num>0)
            {
                int n = num % 10;
                int fact = 1;
                for(int i=1;i<=n;i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }

    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int n = num % 10;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            Console.WriteLine(sum);

            if (sum==temp)
            {
                Console.WriteLine("Krishnamurthy");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy");
            }
        }
    }

    class Disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int original = n;
            int count=0, sum = 0;
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            n = original;
            while(n>0)
            {
                int power = 1;
                int r = n % 10;
                for(int i=1;i<=count;i++)
                {
                    power = power * r;
                }
                sum += power;
                count--;
                n = n / 10;
            }
            if (original == sum)
            {
                Console.WriteLine("Disarium");
            }
            else
            {
                Console.WriteLine("Not Disarium");
            }
        }
    }

    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0, square = 1; ;
            int n = num;
            while(num>0)
            {
                num = num / 10;
                count++;
            }
            num = n;
      
            int power = 1;
            square = num * num;
            for (int i=1;i<=count;i++)
            {
              power = power * 10;
            }
            int rev = square % power;

            if(num==rev)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("Not Automorphic");
            }

        }
    }
/* Single Digit Only
  
 
    class Kapaerkar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num, sum = 0;
            int square = num * num;

            while (square > 0)
            {
                int r = square % 10;
                sum += r;
                square = square / 10;
            }
            num = temp;
            if (num == sum)
            {
                Console.WriteLine("Kapareker");
            }
            else
            {
                Console.WriteLine("Not Kapareker");
            }
        }
    }
*/
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0, sum = 0;
            int temp = num;
            while(num>0)
            {
                int r = num % 10;
                sum += r;
                num = num / 10;
                count++;
            }
            if(sum%count==0)
            {
                Console.WriteLine("Harshad");
            }
            else
            {
                Console.WriteLine("Not Harshad number");
            }
        }
    }

    class Kapaerkar1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int count = 0;
           int square = n * n;
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            n = temp;
            int power = (int)(Math.Pow(10, count));
            int end = square % power;
            int start = square / power;
            //Console.WriteLine(end);
           // Console.WriteLine(start);
            int sum = end + start;
            if(n==sum)
            {
                Console.WriteLine("Kapaerkar");
            }
            else
            {
                Console.WriteLine("Not Kapaerkar");
            }
        }
    }


    class DuckNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0,r;
            int temp = n;

            for(int i=10;i<=n;i++)
            {
                n = n / 10;
            }
             r = n;
            Console.WriteLine(r);
            n = temp;
            while(n>0)
            {
               if(n%10==0)
                {
                    count = 1;
                    break;
                }
                n = n / 10;
            }
           
            if(temp>0 && count==1 && r!=0)
            {
               Console.WriteLine("Duck Number");
            }
            else
            {
                Console.WriteLine("Not Duck Number");
            }
           
        }
    }
    class Series3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                int sq = ((i * i * i) - 1);
                Console.WriteLine(sq);
            }
        }
    }
    class Series4
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                
            }
        }
    }

    class Fibonics1
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
    class Series5
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum * 10 + 1;
                Console.Write(sum+ " ");
            }
        }
    }
    class PrimeAvg
    {
        static void Main(string[] args)
        {
            int sum=0,flag=0;
            for(int i=2;i<=10;i++)
            {
                int count = 0;
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    flag++;
                }
            }
            int avg = sum / flag;
            Console.WriteLine("Average= "+avg );
        }
    }
    class Pattern09
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                if(i%2==0)
                {
                    char ch= 'A';
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                else
                {
                    for(int k=1;k<=i;k++)
                    {
                        Console.Write(k);
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Task09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                if (n >= 2 && n <= 8)
                {
                    Console.WriteLine("Green");
                }
                else
                {
                    Console.WriteLine("Red");
                }
            }
            else
            {
                if(n>8)
                {
                    Console.WriteLine("white");
                }
                else
                {
                    Console.WriteLine("Black");
                }
            }
        }
    }
}
