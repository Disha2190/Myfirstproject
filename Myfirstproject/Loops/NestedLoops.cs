using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Loops
{
    /*  1
        12
        123
        1234    */
    class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
               for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    /* 1234
       123
       12
       1   */
    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    /* 1
       22
       333
       4444*/
    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    /*                *
                     **
                    ***
                   ****    */

    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                
               for (int j = 1; j <= 4; j++)
               {
                    if(j<=4-i)
                    Console.Write(" ");
                    else
                        Console.Write("*");
               }
                 Console.WriteLine();
            }
        }
    }


   /*   *****
        *****
        *****
        ******/

    class Pattern5
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

 /*  11111
     22222
     33333
     44444
     55555*/

    class Pattern6
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5; i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

     /*  12345
         12345
         12345
         12345
         12345 */
    class Pattern7
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

  /*    55555
        44444
        33333
        22222
        11111 */
    class Pattern8
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    /*
        54321
        54321
        54321
        54321
        54321
     */
    class Pattern9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int j=5;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    /*  1  2  3  4  5
     *  6  7  8  9  10
        11 12 13 14 15
        16 17 18 19 20
        21 22 23 24 25 */
    class Pattern10
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    count++;
                    Console.Write(count+"  ");
                }
                Console.WriteLine();
            }
        }
    }


    /*  
        11111
        22222
        33333
        44444
        55555
      */
    class Pattern11
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    /*
         54321
         5432
         543
         54
         5
     */
    class Pattern12
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    /* 
     
        A
        AB
        ABC
        ABCD
                */

    class Pattern13
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    /*
        1
        10
        101
        1010
            */

    class Pattern14
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");

                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
   /*
      ****
      *  *
      *  *
      ****
    */  
    class Pattern15
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if(i==1 || i==4 || j == 1 || j == 4)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

 /*
    DCBA
    DCB
    DC
    D   */
    class Pattern16
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for(char j='D';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    /*
    1
    23
    4561
    23
    456
    */
    class Pattern17
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
        }
    }

 /* 
    *
    **
    * *
    ****
            */

    class Pattern18
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(i==3 && j==2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }

/*
      *
      *
    *****
      *
      *
*/
    class Pattern19
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i==3 || j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


/*
    * * * *
     * * *
      * *
       *
 */
    class Pattern20
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int k=1;k<=i;k++)
                {
                    Console.Write(" ");
                }
                for(int j=4;j>=i;j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

/*
    *    *
    * *  *
    *  * *
    *    *
*/
    class Pattern21
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if(j==1 || j==4 || j==i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

/*
    10101
    01010
    10101
    01010
    10101
*/

    class Pattern22
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
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
}
