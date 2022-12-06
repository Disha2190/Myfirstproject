using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class UsingCopy
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "";
            //copy
            str2 = string.Copy(str1);
            Console.WriteLine("Copied string is: "+str2);
        }
    }
    class UsingCopyto
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World Programming";
            char[] str2 = new char[14];
            Console.WriteLine("String is: "+str1);
            str1.CopyTo(6, str2, 0, 5);
            Console.WriteLine("Copied String is: ");
            foreach(char c in str2)
                Console.WriteLine(c);
        }
    }
}
