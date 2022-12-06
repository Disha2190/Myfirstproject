using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class StringProgram
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("String is: "+str);
            int len = 0;
            foreach(char ch in str)
            {
                Console.Write(ch);
                len++;
            }
            Console.WriteLine();
            Console.WriteLine("String length is: "+len);
        }
    }
    class StringLengthAsProperty
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("String is: "+str);
            Console.WriteLine("String length is: "+str.Length);
            for(int i=0;i<str.Length;i++)
            {
                Console.Write(str[i]);
            }
        }
    }
   
    class AltEle
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("String length is: " + str.Length);
            for (int i = 0; i < str.Length; i+=2)
            {
                Console.Write(str[i]);
            }
        }
    }
    class CheckChar
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("String is: " + str);
            Console.WriteLine("String length is: " + str.Length);
            for (int i = 0; i < str.Length; i += 2)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter any character: ");
            char ch = Char.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0; i<str.Length;i++)
            {
                if (ch == str[i])
                    count++;
            }
            if(count==0)
                Console.WriteLine("Char not present");
            else
                Console.WriteLine("char is present {0} times",count);
        }
    }
    class UpperLower
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine("String is: " + str);
            for (int i = 0; i <str.Length;i++)
            {
                if(Char.IsUpper(str[i]))
                    Console.Write(char.ToLower(str[i]));
                else
                    Console.Write(char.ToUpper(str[i]));
            }
        }
    }
}
