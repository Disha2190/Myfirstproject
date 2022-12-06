using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class StrPattern
    {
        static void Main(string[] args)
        {
            string str = "Hello world of progamming";
            Console.WriteLine(str);
            string[] str1 = str.Split();
           for(int i=0;i<str1.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write(str1[j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
