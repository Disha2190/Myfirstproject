using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.StringProg
{
    class Palindrom
    {
        public static void Palid(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            string str1 = new string(c);
            if((str1.Equals(str)))
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Palindrom.Palid(str);
        }
    }
}
