using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandeling
{
    class Alphabet:SystemException
    {
        public Alphabet()
        {
            Console.WriteLine("String Contain Alphabet");
        }
    }
    class MoreDigits:SystemException
    {
        public MoreDigits()
        {
            Console.WriteLine("Invalid Number of Digits");
        }
    }
    class CustomException3
    {
        public static void Check(string str)
        {
           int cnt = 0;
            char[] ch = str.ToCharArray();
            for(int i=0;i<ch.Length; i++)
            {
                if(char.IsDigit(ch[i]))
                {
                    cnt++;
                }
                else
                {
                    throw new Alphabet();
                }
            }
            if(cnt==ch.Length)
            {
                if(ch.Length==10)
                {
                    Console.WriteLine("Valid String");
                }
                else
                {
                    throw new MoreDigits();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String str = Console.ReadLine();
            try
            {
                CustomException3.Check(str);
            }
            catch
            {
                Console.WriteLine("Handelde....");
            }
        }
    }
}
