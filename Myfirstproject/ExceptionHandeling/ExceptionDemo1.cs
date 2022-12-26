using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class ExceptionDemo1
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 4, 3 };
            try
            {
                a[4] = 89;
            }
            catch(Exception)
            {
                Console.WriteLine("Handle");
            }
            Console.WriteLine("Done");
        }
    }
}
