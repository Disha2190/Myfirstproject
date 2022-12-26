using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class TestException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int sum = 0;
            try
            {
                int x = 10 / sum;
                Console.WriteLine("x: "+x);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Handled........"+e.ToString());
            }
            Console.WriteLine("Hii");
        }
    }
}
