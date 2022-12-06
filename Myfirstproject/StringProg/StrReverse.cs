using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class StrReverse
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine("String is: "+str);
            string strRev = " ";
            for (int i = str.Length - 1; i >= 0; i--)
                strRev = strRev + str[i];

            Console.WriteLine("String in reversed is: "+strRev);
        }
    }
}
