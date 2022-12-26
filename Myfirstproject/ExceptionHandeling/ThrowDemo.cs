using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class ThrowDemo
    {
        public static void Check(int age)
        {
            if(age<18)
            {
                throw new Exception("Invalid age for Driving.....");
            }
            else
            {
                Console.WriteLine("age is valid for driving test.....");
            }
            Console.WriteLine("Hiiiii");
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowDemo.Check(17);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Good");
        }
    }
}
