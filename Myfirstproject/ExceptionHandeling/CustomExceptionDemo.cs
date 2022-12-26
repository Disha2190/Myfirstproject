using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class NegativeNumberException:SystemException
    {
        public NegativeNumberException()
        {
            Console.WriteLine("Negative nuber exception");
        }
        public NegativeNumberException(string s):base(s)
        {

        }
    }
    class CustomExceptionDemo
    {
        public static void Valid(int n)
        {
            if(n<0)
            {
                throw new NegativeNumberException();
            }
            else
            {
                Console.WriteLine("Valid number");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Valid(-2);
            }
            catch(Exception e)
            {
                Console.WriteLine("Handle......"+e.Message);
            }
        }
    }
}
