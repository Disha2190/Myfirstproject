using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ExceptionHandelling
{
    class ExceptionFinallyDemo1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            try
            {
                Console.WriteLine(10/sum);
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
            Console.WriteLine("Hii!!!!!");
        }
    }
}
