using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class NumberNotAllowedException:SystemException
    {
        public NumberNotAllowedException()
        {
            Console.WriteLine("Digit not allowed in text");
        }
    }
    class CustomDemo2
    {
        public static void Check(string s)
        {
            bool ispresent = false;
            for(int i=0;i<s.Length;i++)
            {
                if(Char.IsDigit(s[i]))
                {
                    ispresent = true;
                    break;
                }
            }
            if(ispresent==true)
            {
                throw new NumberNotAllowedException();
            }
            Console.WriteLine("Valid String");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENter string:");
            string s = Console.ReadLine();
            try
            {
                Check(s);
            }
            catch
            {
                Console.WriteLine("Handle.......");
            }
        }
    }
}
