using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Revision1
{
    //1. WAP to print even numbers from 121 to 229 using do-while loop.
    class TaskL1
    {
        static void Main(string[] args)
        {
            int num = 121;
            do
            {
                if(num%2==0)
                {
                    Console.WriteLine(num);
                }
                num++;
            } while (num<=229);
        }
    }
    //2. WAP to show the use of break statement(in for loop)

    class TaskL2
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=10;i++)
            {
                if(i==5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    //3.Write a program to print all alphabets from a to z. - using  for loop
    class TaskL3
    {
        static void Main(string[] args)
        {
            /*for(int i=97;i<=122;i++)
            {
                Console.WriteLine((char)i);
            }*/
            for(char i='a';i<='z';i++)
            {
                Console.WriteLine(i);
            }
        }
    }
//4.	 Write a  program to find sum of all even numbers between 1 to n.

    class TaskL4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0;i<=n;i++)
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
//5.	 Write a program to find sum of all odd numbers between 1 to n.

    class TaskL5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }

    //6. Write a  program to count number of digits in any number

    class TaskL6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
//7.	 Write a  program to calculate product of digits of any number.

    class TaskL7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int prod = 1;
            while(n>0)
            {
                int temp = n % 10;
                prod *= temp;
                n = n / 10;
            }
            Console.WriteLine(prod);
        }
    }
//8.	Write a program to find frequency of each digit in a given integer.

    class TaskL8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Tne frequency of "+i+" is");
                count = 0;
                for(int j=n;j>0;j=j/10)
                {
                    int r = j % 10;
                    if(r==i)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
//9.	Find all prime number between 400 to 300;

    class TaskL9
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=400;i>=300;i--)
            {
                count = 0;
                for(int j=2;j<=i/2;j++)
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
                }
            }
        }
    }
//10.	.WAP to print table of given no

    class TaskL10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i*n);
            }
        }
    }
    //11.	WAP to accept base and index from user and calculates power
    class TaskL11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exponent");
            int ex = int.Parse(Console.ReadLine());
            int power = 1;
            for(int i=1;i<=ex;i++)
            {
                power *= b;
            }
            Console.WriteLine(power);
        }
    }
//12.	s=1!+2!+3!.........+n! find s

    class TaskL12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    s *= j;
                }
            }
            Console.WriteLine(s);
        }
    }
//13.	 check no is krishnamurthi or not
    // 153=1!+5!+3!=153
    class TaskL13
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

            if (sum == temp)
            {
                Console.WriteLine("Krishnamurthy");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy");
            }
        }
    }
//14.	Disarum no 135=1+3*3+5*5*5=135

    class TaskL14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int orignal = n;
            int count = 0, sum = 0;
            while(n>0)
            {
                n = n / 10;
                count++;
            }
            int temp = orignal;
            while(n>0)
            {
                int product = 1;
                int t = orignal % 10;
                for(int i=1;i<=count;i++)
                {
                    product = product * t;
                }
                count--;
                orignal = orignal / 10;
                sum += product;
            }
            if(sum==temp)
            {
                Console.WriteLine("Disarum");
            }
            else
            {
                Console.WriteLine("Not Disarum");
            }
        }
    }
//15.	check no is palimdrom or not

    class TaskL15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int t = n;
            int sum = 0;
            while(n>0)
            {
                int r = n % 10;
                sum = sum * 10 + r;
                n= n / 10;
            }
            if(t==sum)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
    }

//1.	Write a program in  to display the first 10 terms of the following series:
//10, 20, 30, 40, ……..

    class TaskL16
    {
        static void Main(string[] args)
        {
            for(int i=10;i<=100;i+=10)
            {
                Console.Write(i+" ");
            }
        }
    }
//2.	Write the program to display the first ten terms of the following series:
//1, 4, 9, 16,

    class TaskL17
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Console.Write(i*i+" ");
            }
        }
    }
//3.	Write the program to display the first ten terms of the following series:
//1, 2, 4, 7, 11,

    class TaskL18
    {
        static void Main(string[] args)
        {
            int sum = 1;
            for (int i=0;i<=10;i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
    }
//4.	Print Series 2 -4 6 -8………n terms

    class TaskL19
    {
        static void Main(string[] args)
        {
            int n = 20;
            for(int i=0,d=2,f=2;i<=n;i++)
            {
                if(f%2==0)
                {
                    Console.Write(d+" ");
                }
                else
                {
                    Console.Write(-d+" ");
                }
                d += 2;
                f++;
            }
        }
    }

//5.	Print Series 1  11  111  111……..n terms

    class TaskL20
    {
        static void Main(string[] args)
        {
            int j = 1;
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum * 10 + j;
                Console.Write(sum+" ");
            }
        }
    }

    //Write a program that takes the quantity of milk and oil as input from user. Milk is 40 rs. per liter and
    //oil is 50 rs. per liter. Take the input from user till the total exceeds 500. If total exceeds 500 display
    //the quantity of milk and oil entered.
    class TaskL21
    {
        static void Main(string[] args)
        {
            int milkqu,totmilk=0;
            int oilqu,totoil=0;
            int total = 0;
            do
            {
                Console.WriteLine("Enter quantity of milk: ");
                milkqu = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter quantity of oil: ");
                oilqu = int.Parse(Console.ReadLine());
                totmilk += milkqu;
                totoil += oilqu;
                total = milkqu * 40 + oilqu * 50;
            } while (total < 500);
            Console.WriteLine("Total Milk: "+totmilk);
            Console.WriteLine("Total Oil: "+totoil);
            Console.WriteLine("Total: "+total);
        }
    }
    //18.	write a program that takes a number as input from user. The key number is 4 and the user enters
    //single digit numbers. Ask the user for a number till he gets the correct answer. Then display the number
    //of tries it took to guess the correct number.
    class TaskL22
    {
        static void Main(string[] args)
        {
            int n = 4;
            for(; ; )
            {
                Console.WriteLine("Enter the number:");
                int num = int.Parse(Console.ReadLine());
                if(num<n)
                {
                    Console.WriteLine("Number is smaller pls try again");
                    continue;
                }
                else if(num>n)
                {
                    Console.WriteLine("Number is greater please try again ");
                    continue;
                }
                else
                {
                    Console.WriteLine("gussed number is right");
                    break;
                }
            }
        }
    }

    /*19.	You have 20 barrels of fuel. The price per barrel is 89rs. For the first 10 barrels. If someone wants more than 10 barrels, the price reduces by the number of barrels bought.
    For e.g.the price of 6 barrels is 6 * 89
But price of 12 barrels is 12 * (89 - 12)
or price of 18 barrels is 18 * (89 - 18) and so on.
Display all the prices from 1 to 20 barrels.
    */
    class TaskL23
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                int total = i * 89;
                Console.WriteLine("Price of "+i+" barrelis: "+total);
            }
            for(int i=11;i<=20;i++)
            {
                int total = i * (89 - i);
                Console.WriteLine("Price of "+i+" barrel is: "+total);
            }
        }
    }
    class PatternL1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL4
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=n;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=i;k<=n;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i-1;j++)
                {
                    Console.Write(" ");
                }
                for(int k=i;k<=n;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL8
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1,k=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL9
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if((i+j)%2==0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL10
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            for(char i='A';i<=n;i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class PatternL11
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int k = 1;
            for(char i='A';i<=n;i++)
            {
                for(int j=1;j<=k;j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
                k++;
            }
        }
    }
}
