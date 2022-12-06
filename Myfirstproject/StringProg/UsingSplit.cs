using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class UsingSplit
    {
        static void Main(string[] args)
        {
            string str = "Hello I am Disha";
            Console.WriteLine("String is: " + str);
            string[] strArr = str.Split(' ');
            Console.WriteLine("No of string present in {0} is {1}",str,strArr.Length);
            foreach(string str2 in strArr)
                Console.WriteLine(str2);
        }
    }
}
