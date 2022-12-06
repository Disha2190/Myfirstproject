using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class IndexPos
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            Console.WriteLine("The string is: "+str);
            Console.WriteLine("Enter the char: ");
            char ch = char.Parse(Console.ReadLine());
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==ch)
                {
                    Console.WriteLine("Index of char ch is: "+(i+1));
                }
            }
        }
    }
}
