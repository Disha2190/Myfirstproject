using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class UsingCompare
    {
        static void Main(string[] args)
        {
            string str1 = "ABB";
            string str2 = "ABD";
            //compare return less than 0 if the first preceds the second string in sort order
            //return 0 if both strings are equal
            //return positive or greater than 0 if first string follows the second string in sort order
            int comparison = string.Compare(str1, str2);
            if(comparison==0)
                Console.WriteLine("Both the string are equal");
            else if(comparison<0)
                Console.WriteLine("Less tham 0 first string precedes the second string in sort order");
            else
                Console.WriteLine("greater than 0 first string followsthe second string in sort order");
        }
    }
}
