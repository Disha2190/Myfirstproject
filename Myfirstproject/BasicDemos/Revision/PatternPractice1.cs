using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.BasicDemos.Revision
{
    class Pattern01
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern02
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern03
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern04
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=n;i>=1;i--)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern05
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=n;i>=1;i--)
            {
                for(int j=n;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern06
    {
        static void Main(string[] args)
        {
            int k = 1;
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(k+" ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern07
    {
        static void Main(string[] args)
        {
            int k = 1;
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(k+" ");
                    k += 2;
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern08
    {
        static void Main(string[] args)
        {
            int k = 2;
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(k+" ");
                    k += 2;
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern09
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write(i*j+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern010
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=3;j++)
                {
                    Console.Write(j+" "+i+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern011
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=3;j++)
                {
                    Console.Write(i+" "+j+" ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern012
    {
        static void Main(string[] args)
        {
            int k;
            int n = int.Parse(Console.ReadLine());
            for(int i = 1;i<=n;i++)
            {
                k = 1;
                for(int j=1;j<=n;j++)
                {
                    Console.Write(k+" ");
                    k += 5;
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern013
    {
        static void Main(string[] args)
        {
            int x, y;
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                x = i;
                y = n - i + 1;
                for(int j=1;j<=n;j++)
                {
                    if(j%2==1)
                    {
                        Console.Write(x+" ");
                    }
                    else
                    {
                        Console.Write(y+" ");
                    }
                    x = x + n;
                    y = y + n;
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern014
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        }
    }
}
