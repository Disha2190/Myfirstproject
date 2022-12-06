using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class Concanate
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            string str = "";
            foreach (char ch in str1)
                str = str + ch;
            foreach (char ch in str2)
                str = str + ch;

            Console.WriteLine("Concinates String is: "+str);
        }
    }
    class Concanate1
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            foreach(char ch in str2)
            {
                str1 = str1 + ch;
            }
            Console.WriteLine("Concinated string is: "+str1);
        }
    }

    class Concanate3
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            string str=string.Concat(str1,str2);
            Console.WriteLine("Concinated string is: " + str1);
        }
    }
    class Concanate4
    {  //Concat Multiple Strings
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            string str3 = " Prgramming";
            string[] strArr = new string[3];
            strArr[0] = str1;
            strArr[1] = str2;
            strArr[2] = str3;
            string str = string.Concat(strArr);
            Console.WriteLine("Concinated string is: " + str);
        }
    }
    class Concanate5
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            string str3 = " Prgramming";
            string str = str1 + str2+str3;
            Console.WriteLine("Concinated string is: " + str);
        }
    }

}
