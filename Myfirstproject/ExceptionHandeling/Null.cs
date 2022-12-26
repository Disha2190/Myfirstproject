using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class Null
    {
        static String s = null;
        static void Main(string[] args)
        {
            try
            {
                if(s==null)
                {
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Handelled......."+e.ToString());
            }
            Console.WriteLine("Hii");
        }
    }
}
