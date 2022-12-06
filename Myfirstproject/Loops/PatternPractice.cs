using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    class Pattern23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = i; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < n; j++)
                {
                    Console.Write("*");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /*   class Pattern30
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    for (int j = i; j <= n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = i; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    for(int i=1;i<=n;i++)
                    {   
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(" ");
                    }
                    for(int j=i;j<=n;j++)
                    {
                        Console.Write("* ");
                    }
                    for(int j=i;j<=n;j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    }
                }
            }
        }*/

    

    
}
