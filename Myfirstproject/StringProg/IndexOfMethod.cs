using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class IndexOfMethod
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            string str1 = " World";
            int position=str.IndexOf(str1);
            Console.WriteLine("String {0} is present at {1} location",str1,position);
        }
    }
}
